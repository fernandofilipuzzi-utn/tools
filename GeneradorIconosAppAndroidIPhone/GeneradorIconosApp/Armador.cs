using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GeneradorIconosApp
{
    public class Armador
    {
        public string DirectorioDestino;
        Image imagenSeleccionada;
        public double MargenPorc { get; set; }= 10;

        public Armador(Image imagenOrigen,string pathDestino)
        {
            DirectorioDestino = pathDestino;
            imagenSeleccionada= imagenOrigen;
        }

        public void GenerarFicheros()
        {
            ClearFiles();
            CrearAppIcon();
            CrearMipmapAnydpiV26();
            CrearMips();
            CrearResources();
            CrearFicherosAdicionales();
        }

        private void ClearFiles()
        {
            string [] listaFiles = Directory.GetFiles(DirectorioDestino);
            foreach (string path in listaFiles)
            {
                File.Delete(path);             
            }
            string[] listaDirectories = Directory.GetDirectories(DirectorioDestino);
            foreach (string path in listaDirectories)
            {
                Directory.Delete(path, true);
            }
        }

        private void CrearAppIcon()
        {
            crearCarpeta("AppIcon.appiconset", out string pathDirOrigen,out string pathDirDestino );
            copiarFicheros(new List<string> { "Contents.json" }, pathDirOrigen, pathDirDestino);
            crearImagenes(GetIcons(), pathDirDestino);
        }
        private void CrearMipmapAnydpiV26()
        {
            crearCarpeta("mipmap-anydpi-v26", out string pathDirOrigen, out string pathDirDestino);
            List<string> ficheros = new List<string> {
                "icon.xml",
                "icon_round.xml"
            };
            copiarFicheros(ficheros, pathDirOrigen, pathDirDestino);
        }
        private void CrearMips()
        {
            foreach (var target in GetMipDirs())
            {
                crearCarpeta(target.Nombre, out string pathOrigen, out string pathDirDestino);
                crearImagenes(GetMipImages(target.Size), pathDirDestino);
            }
        }
        private void CrearResources()
        {
            crearCarpeta("Resources", out string pathDirOrigen, out string pathDirDestino);            
            copiarFicheros(new List<string> { "LaunchScreen.storyboard" }, pathDirOrigen, pathDirDestino);
            crearImagenes(GetResourceImages(), pathDirDestino);
        }

        private void crearCarpeta(string target, out string pathOrigen, out string pathDirDestino)
        {
            pathDirDestino = Path.GetFullPath(Path.Combine(DirectorioDestino, target));
            Directory.CreateDirectory(pathDirDestino);
            pathOrigen = Path.GetFullPath(Path.Combine("template", target));
        }
        private void copiarFicheros(List<string> targets, string pathOrigen, string pathDirDestino)
        {
            foreach (string target in targets)
            {
                string origen = Path.GetFullPath(Path.Combine(pathOrigen, target));
                string destino = Path.GetFullPath(Path.Combine(pathDirDestino, target));
                File.Copy(origen, destino);
            }
        }
        private void crearImagenes(List<dynamic> targets, string pathDirDestino)
        {
            foreach (var img in targets)
            {
                #region escalado de los limites de la imagen
                double imgAncho =img.Ancho;
                double imgAlto = img.Alto;
                double relacionIcono= imgAncho / imgAlto;
                if (relacionIcono > 1)
                {
                    imgAncho = imgAncho/relacionIcono;
                }
                else
                {
                    imgAlto = imgAlto* relacionIcono;
                }
                #endregion

                #region  reducción segun el margen 
                int ancho = (int)(imgAncho - MargenPorc / 100.0 * 2 * imgAncho);
                int alto = (int)(imgAlto - MargenPorc / 100.0 * 2 * imgAlto);
                int x = (int)Math.Floor(MargenPorc / 100.0 * img.Ancho);
                int y = (int)Math.Floor(MargenPorc / 100.0 * img.Alto );
                #endregion

                #region area de dibujo
                Bitmap resizedImage = new Bitmap(img.Ancho, img.Alto);
                Graphics g = Graphics.FromImage(resizedImage);
                #endregion

                #region rescalado de la imagen
                int anchoImagen = imagenSeleccionada.Width;
                int altoImagen = imagenSeleccionada.Height;
                double relacion = anchoImagen*1.0/ altoImagen;

                if (anchoImagen > 1)
                {
                    int anchoEscalado = (int)(ancho / relacion);
                    int xp = x/2+(img.Ancho/2- anchoEscalado/2)/2;
                    g.DrawImage(imagenSeleccionada, xp, y, anchoEscalado, alto);
                }
                else
                {
                    int altoEscalado = (int)(alto * relacion);
                    int yp =  y/2+(img.Alto / 2 - altoEscalado / 2) / 2;
                    g.DrawImage(imagenSeleccionada, x, yp, ancho, altoEscalado);
                }
                #endregion

                string destino = Path.GetFullPath(Path.Combine(pathDirDestino, img.Nombre));
                resizedImage.Save(destino, ImageFormat.Png);
                
                g.Dispose();
                resizedImage.Dispose();
            }
        }

        private List<dynamic> GetIcons()
        {
            var targets = new List<dynamic>()
            {
                new {Nombre="Icon16.png" , Ancho=16, Alto=16 },
                new {Nombre="Icon20.png" , Ancho=20, Alto=20 },
                new {Nombre="Icon29.png" , Ancho=29, Alto=29 },
                new {Nombre="Icon32.png" , Ancho=32, Alto=32 },
                new {Nombre="Icon40.png" , Ancho=40, Alto=40 },
                new {Nombre="Icon48.png" , Ancho=48, Alto=48 },
                new {Nombre="Icon50.png" , Ancho=50, Alto=50 },
                new {Nombre="Icon55.png" , Ancho=55, Alto=55 },
                new {Nombre="Icon57.png" , Ancho=57, Alto=57 },
                new {Nombre="Icon58.png" , Ancho=58, Alto=58 },
                new {Nombre="Icon60.png" , Ancho=60, Alto=60 },
                new {Nombre="Icon64.png" , Ancho=64, Alto=64 },
                new {Nombre="Icon66.png" , Ancho=66, Alto=66 },
                new {Nombre="Icon72.png" , Ancho=72, Alto=72 },
                new {Nombre="Icon76.png" , Ancho=76, Alto=76 },
                new {Nombre="Icon80.png" , Ancho=80, Alto=80 },
                new {Nombre="Icon87.png" , Ancho=87, Alto=87 },
                new {Nombre="Icon88.png" , Ancho=88, Alto=88 },
                new {Nombre="Icon92.png" , Ancho=92, Alto=92 },
                new {Nombre="Icon100.png" , Ancho=100, Alto=100 },
                new {Nombre="Icon102.png" , Ancho=102, Alto=102 },
                new {Nombre="Icon114.png" , Ancho=114, Alto=114 },
                new {Nombre="Icon120.png" , Ancho=120, Alto=120 },
                new {Nombre="Icon128.png" , Ancho=128, Alto=128 },
                new {Nombre="Icon144.png" , Ancho=144, Alto=144 },
                new {Nombre="Icon152.png" , Ancho=152, Alto=152 },
                new {Nombre="Icon167.png" , Ancho=167, Alto=167 },
                new {Nombre="Icon172.png" , Ancho=172, Alto=172 },
                new {Nombre="Icon180.png" , Ancho=180, Alto=180 },
                new {Nombre="Icon196.png" , Ancho=196, Alto=196 },
                new {Nombre="Icon216.png" , Ancho=216, Alto=216 },
                new {Nombre="Icon256.png" , Ancho=256, Alto=256 },
                new {Nombre="Icon512.png" , Ancho=512, Alto=512 },
                new {Nombre="Icon1024.png" , Ancho=1024, Alto=1024 },
                new {Nombre="Iconwatch.png" , Ancho=55, Alto=55 },
            };
            return targets;
        }
        private List<dynamic> GetMipDirs()
        {
            var mipDirs = new List<dynamic>
            {
                new { Nombre="mipmap-hdpi", Size=72 },
                new { Nombre="mipmap-mdpi", Size=48 },
                new { Nombre="mipmap-xhdpi", Size=96 },
                new { Nombre="mipmap-xxhdpi", Size=144 },
                new { Nombre="mipmap-xxxhdpi", Size=192 }
            };
            return mipDirs;
        }
        private List<dynamic> GetMipImages(int size)
        {
            var mips = new List<dynamic>()
            {
                new {Nombre="ic_launcher.png" , Ancho=size, Alto=size },
                new {Nombre="icon.png" , Ancho=size, Alto=size },
                new {Nombre="launcher_foreground.png" , Ancho=size, Alto=size }
            };
            return mips;
        }
        private List<dynamic> GetResourceImages()
        {
            var targets = new List<dynamic>
            {
                new {Nombre="Default.png", Ancho=320, Alto=480},
                new {Nombre="Default@2x.png", Ancho=640, Alto=960},
                new {Nombre="Default-568h@2x.png", Ancho = 640, Alto = 1136},
                new {Nombre="Default-Portrait.png", Ancho=768, Alto=1004},
                new {Nombre="Default-Portrait@2x.png", Ancho=1536, Alto=2008},
            };
            return targets;
        }

        private void CrearFicherosAdicionales()
        {
            List<string> ficheros = new List<string>
            {
                "Info.plist",
                "AndroidManifest.xml",
                "AssemblyInfo.cs",
            };
            string pathDirOrigen = Path.GetFullPath("template");
            copiarFicheros(ficheros, pathDirOrigen, DirectorioDestino);

            List<dynamic> imagenes = new List<dynamic>{
                new {Nombre="appstore.png", Ancho=1024, Alto=1024 },
                new {Nombre="playstore.png", Ancho=512, Alto=512 },
            };
            crearImagenes(imagenes, DirectorioDestino);
        }
    }
}