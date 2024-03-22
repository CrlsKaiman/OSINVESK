using System;

class Program
{
    static void Main(string[] args)
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear(); // Limpia la consola cada vez que se muestra el menú
            MostrarBanner();
            Console.WriteLine("\nSelecciona una categoría:");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Telefonía");
            Console.WriteLine("2. Buscadores");
            Console.WriteLine("3. Web");
            Console.WriteLine("4. Email");
            Console.WriteLine("5. Personas");
            Console.WriteLine("6. Financiero");
            Console.WriteLine("7. Redes Sociales");
            Console.WriteLine("8. Herramientas");
            Console.WriteLine("9. Mapas");
            Console.Write("\nIntroduce el número de tu elección: ");

            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    MostrarTelefonia();
                    break;
                case "2":
                    MostrarBuscadores();
                    break;
                case "3":
                    MostrarWeb();
                    break;
                case "4":
                    MostrarEmail();
                    break;
                case "5":
                    MostrarPersonas();
                    break;
                case "6":
                    MostrarFinanciero();
                    break;
                case "7":
                    MostrarRedesSociales();
                    break;
                case "8":
                    MostrarHerramientas();
                    break;
                case "9":
                    MostrarMapas();
                    break;
                // Añade más casos según sea necesario
                case "0":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no reconocida.");
                    break;
            }
        }
    }

    static void MostrarBanner()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" @@@@@@    @@@@@@   @@@  @@@  @@@  @@@  @@@  @@@@@@@@   @@@@@@   @@@  @@@  ");
        Console.WriteLine("@@@@@@@@  @@@@@@@   @@@  @@@@ @@@  @@@  @@@  @@@@@@@@  @@@@@@@   @@@  @@@  ");
        Console.WriteLine("@@!  @@@  !@@       @@!  @@!@!@@@  @@!  @@@  @@!       !@@       @@!  !@@  ");
        Console.WriteLine("!@!  @!@  !@!       !@!  !@!!@!@!  !@!  @!@  !@!       !@!       !@!  @!!  ");
        Console.WriteLine("@!@  !@!  !!@@!!    !!@  @!@ !!@!  @!@  !@!  @!!!:!    !!@@!!    @!@@!@!   ");
        Console.WriteLine("!@!  !!!   !!@!!!   !!!  !@!  !!!  !@!  !!!  !!!!!:     !!@!!!   !!@!!!    ");
        Console.WriteLine("!!:  !!!       !:!  !!:  !!:  !!!  :!:  !!:  !!:            !:!  !!: :!!   ");
        Console.WriteLine(":!:  !:!      !:!   :!:  :!:  !:!   ::!!:!   :!:           !:!   :!:  !:!  ");
        Console.WriteLine("::::: ::  :::: ::    ::   ::   ::    ::::     :: ::::  :::: ::    ::  :::  ");
        Console.WriteLine(" : :  :   :: : :    :    ::    :      :      : :: ::   :: : :     :   :::  ");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Enlaces a herramientas OSINT.");
        Console.WriteLine("Creado por KMN.");
        Console.ForegroundColor = ConsoleColor.White;


    }
    static void MostrarPersonas()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("--- Personas ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mABC TELÉFONOS\u001b[0m - Agenda telefónica y de direcciones.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.abctelefonos.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mSPOKEO\u001b[0m - Búsqueda por nombre, teléfono, dirección o email.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.spokeo.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mLULLAR\u001b[0m - Búsqueda de perfiles por email, nombre o pseudónimo.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://lullar-com-3.appspot.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mGENEANET\u001b[1m - Búsqueda de familiares, árbol genealógico.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://es.geneanet.org/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mYANSI\u001b[0m- Búsqueda de persona.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   http://www.yasni.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mPEEKYOU\u001b[0m - Búsqueda de personas EEUU.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.peekyou.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mWEBMII\u001b[0m - Buscador de personas.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://webmii.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mREDES SOCIALES\u001b[0m - Buscador CSE de Redes Sociales.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=014962206127055623955:o1ggmde5erw");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona una tecla para volver al menú principal.");
        Console.ReadKey();
    }

    static void MostrarTelefonia()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- Telefonía ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mCNMC MV\u001b[0m - Consulta operadora de línea móvil.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://numeracionyoperadores.cnmc.es/portabilidad/movil");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mEMOBILETRACKER\u001b[0m - Consulta posible usuario de una línea.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.emobiletracker.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mPREFIJOS INTERNACIONALES\u001b[0m - Listado de prefijos telefónicos internacionales.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://telegra.ph/CODIGOS-TELEF%C3%93NICOS-06-07");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mDEFASTRA\u001b[0m - Información de un número de teléfono.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://defastra.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mBIZUM\u001b[0m.");
        Console.WriteLine("   Puedes obtener el nombre y las iniciales del apellido antes de confirmar el envío.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mTRUECALLER\u001b[0m");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   http://www.truecaller.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mDENUNCIAS\u001b[0m");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   http://www.numerosdetelefono.es/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mCALCULADORA DE IMEI\u001b[0m - Obtén el dígito de control.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.imei.info/calc");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mIMEI DATA\u001b[0m - Obtén marca y modelo del terminal.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://imeidata.org/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mABC TELÉFONOS\u001b[0m - Agenda telefónica y de direcciones.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.abctelefonos.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mSPOKEO\u001b[0m - Búsqueda por nombre, teléfono, dirección o email.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.spokeo.com/");
        // Continúa añadiendo enlaces aquí
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona una tecla para volver al menú principal.");
        Console.ReadKey();

    }

    static void MostrarBuscadores()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- Buscadores ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mTELEGRAM\u001b[0m - Buscador CSE para Telegram.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=81cb958ecea7c4704#gsc.tab=0");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mPODER JUDICIAL\u001b[0m - Buscador CSE de la web de poder judicial.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=6794950957f385762#gsc.tab=0");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mBOE\u001b[0m - Buscador CSE del BOE.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=2000f15a773124411#gsc.tab=0");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mPDF\u001b[0m - Buscador CSE de documentos PDF.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=a29e2bf9081824eb6#gsc.tab=0");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mMINISTERIO DE JUSTICIA\u001b[0m - Buscador CSE del Ministerio de Justicia.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=fc935ac5fb7eea72a");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mREDES SOCIALES\u001b[0m - Buscador CSE de Redes Sociales.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=014962206127055623955:o1ggmde5erw");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mDOCUMENTOS\u001b[0m - Buscador CSE de documentos.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=000844673835878958728:5pazxldkueq");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mOPERADORES DE GOOGLE\u001b[0m - Listado de operadores de Google (Dorks).");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.googleguide.com/advanced_operators_reference.html");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mINMUEBLES\u001b[0m - Buscador CSE de inmuebles, introduce una dirección y muestra anuncios.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=a71929c6e83dd4f19#gsc.tab=0");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mPERSONAS\u001b[0m. Buscador CSE de personas.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=d729c838d3156499b#gsc.tab=0");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("UTOPIA CSE - Start.me del metabuscador con CSE.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://start.me/p/EL84Km/cse-utopia");
        // Continúa añadiendo enlaces aquí
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona una tecla para volver al menú principal.");
        Console.ReadKey();

    }

    static void MostrarWeb()

    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- WEB (DNS, IP...) ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mIP INFO\u001b[0m - Herramienta de información de IP.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://ipinfo.io/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mVIRUS TOTAL\u001b[0m - Plataforma de análisis de malware y URL.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.virustotal.com/gui/home/url");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mEL HACKER\u001b[0m - Herramienta de geolocalización.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.elhacker.net/geolocalizacion.html");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mSECURITY TRAILS\u001b[0m - Plataforma de inteligencia de amenazas.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://securitytrails.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mWHOXY\u001b[0m - Herramienta de búsqueda de dominios WHOIS.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.whoxy.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mURL SCAN\u001b[0m - Escáner de seguridad de URL.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://urlscan.io");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mMESSAGE HEADER ANALYZER\u001b[0m - Analizador de encabezados de correo electrónico.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://mha.azurewebsites.net/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mMX TOOLBOX\u001b[0m - Conjunto de herramientas de administración de correo.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://mxtoolbox.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mABUSE IP\u001b[0m - Base de datos de IP abusivas.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.abuseipdb.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mUNSHORTEN IT\u001b[0m - Herramienta para desenmascarar URLs cortas.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://unshorten.it/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mIANA\u001b[0m - Asignaciones de recursos de Internet.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.iana.org/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mROBTEX\u001b[0m - Herramienta de análisis de IP, DNS, hostname y más.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.robtex.com/");
        Console.ForegroundColor = ConsoleColor.White;
        // Continúa añadiendo enlaces aquí
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona una tecla para volver al menú principal.");
        Console.ReadKey();

    }

    static void MostrarEmail()

    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- Email ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mMOHMAL\u001b[0m - Correo temporal.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.mohmal.com/es");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mEPIEOS\u001b[0m - Plataforma de correos electrónicos seguros.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://epieos.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mHUNTER.IO\u001b[0m - Herramienta de búsqueda de direcciones de correo electrónico.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://hunter.io/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mPAYPAL RECOVERY\u001b[0m - Recuperación de contraseña de PayPal.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.paypal.com/authflow/password-recovery/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mDEFASTRA\u001b[0m - OSINT correo electrónico.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://defastra.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mVERIFYMAIL\u001b[0m - Verificación de direcciones de correo electrónico.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   http://verifyemail.io/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mOSINT INDUSTRIES\u001b[0m - Inteligencia de fuentes abiertas.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   http://osint.industries/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mEPIEOS\u001b[0m - OSINT Correo Electrónico.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://epieos.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mSPOKEO\u001b[0m - Búsqueda por nombre, teléfono, dirección o email.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.spokeo.com/");
        // Continúa añadiendo enlaces aquí
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona una tecla para volver al menú principal.");
        Console.ReadKey();

    }

    static void MostrarFinanciero()

    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- Financiero ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mIBAN\u001b[0m - Identifica la entidad de la Cuenta Corriente.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.ibancalculator.com/iban_validieren.html");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mBIN\u001b[0m - Valida el número de una tarjeta y se obtiene entidad bancaria/emisora.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://binlist.net/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mCNMV\u001b[0m - Comisión Nacional del Mercado de Valores.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.cnmv.es/portal/home.aspx");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mLIBREBORME\u001b[0m - Herramienta gratuita análisis de Registro Mercantil.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   http://librebor.me/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mDATOSCIF\u001b[0m - Base de datos del BORME, crea grafos.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   http://datoscif.net");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mARKHAM INTELLIGENCE\u001b[0m - Identificar Blockchain.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.arkhamintelligence.com/es");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mCAJEROS\u001b[0m - Buscador de cajeros.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.oficinasbanco.topcredi.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mGLASSCHAIN\u001b[0m - Exchange de direcciones.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://glasschain.org/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mBLOCKPATH\u001b[0m - Rastreo de criptos.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://blockpath.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mINDEED\u001b[0m - Página web de ofertas de empleo.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://es.indeed.com/?from=gnav-homepage");
        Console.WriteLine("");
        Console.WriteLine("");
        // Continúa añadiendo enlaces aquí
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona una tecla para volver al menú principal.");
        Console.ReadKey();

    }

    static void MostrarRedesSociales()

    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- Redes Sociales ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mINSTAGRAM ID\u001b[0m - Obtener la ID a través del nombre de la cuenta.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.instafollowers.co/find-instagram-user-id");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mTIKTOK TIMESTAMP\u001b[0m - Extrae la fecha y hora de subida.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://bellingcat.github.io/tiktok-timestamp/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mPROFILE DISCOVER\u001b[0m - Buscador de Redes Sociales.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://profilediscover.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mREDES SOCIALES\u001b[0m - Buscador CSE de Redes Sociales.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://cse.google.com/cse?cx=014962206127055623955:o1ggmde5erw");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mLULLAR\u001b[0m - Búsqueda de perfiles por email, nombre o pseudónimo.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://com.lullar.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mGEOSOCIAL FOOTPRINT\u001b[0m - Geolocalización para Twitter (X).");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://geosocialfootprint.com/"); Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mSOCIAL SEARCHER\u001b[0m - Motor de búsqueda en redes sociales.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://social-searcher.com/");
        Console.WriteLine("");
        // Continúa añadiendo enlaces aquí
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona una tecla para volver al menú principal.");
        Console.ReadKey();

    }

    static void MostrarHerramientas()

    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- Herramientas & Forense ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mVER EXIF\u001b[0m - Visor de metadatos.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.verexif.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mMETADATA2GO\u001b[0m - Visor de metadatos");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.metadata2go.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mTIMESTAMP\u001b[0m - Conversor timestamp a formato común.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.epochconverter.com/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mUSER-AGENT\u001b[0m - Interpreta cabecera y aporta datos del SO y navegador.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://explore.whatismybrowser.com/useragents/parse/#parse-useragent");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mLAMPYRE\u001b[0m - Herramienta OSINT de pago.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   http://lampyre.io/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mSEARCH.0T\u001b[0m - Búsqueda de información filtrada (leaks).");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://search.0t.rocks/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mINTELX\u001b[0m - Búsqueda de información filtrada (leaks).");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://intelx.io/");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mSUNCALC\u001b[0m - Para saber la hora en la que fue tomada una fotografía.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.suncalc.org/");
        Console.WriteLine("");
        Console.WriteLine("");
        // Continúa añadiendo enlaces aquí
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona una tecla para volver al menú principal.");
        Console.ReadKey();

    }

    static void MostrarMapas()

    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n--- Mapas ---");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mCÁMARAS DE VALENCIA\u001b[0m - Cámaras de control de tráfico de Valencia.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://geoportal.valencia.es/portal/apps/webappviewer/index.html?id=3a302533ea51497f9a2af6b723cc9495");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mDUALMAP\u001b[0m - Mapas conbinados en una sola vista.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://data.mashedworld.com/dualmaps/map.htm");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mCATASTRO\u001b[0m - Sede Electrónica del Catastro.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www1.sedecatastro.gob.es/CYCBienInmueble/OVCBusqueda.aspx");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mMAPILLARY\u001b[0m - Imágenes a nivel de calle y datos cartográficos");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://www.mapillary.com");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\u001b[1mWAYBACK\u001b[0m - Muestra imágenes satélite del pasado.");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("   https://livingatlas.arcgis.com/wayback");
        Console.WriteLine("");
        Console.WriteLine("");
        // Continúa añadiendo enlaces aquí
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nPresiona una tecla para volver al menú principal.");
        Console.ReadKey();
    }

    // Define métodos similares para las otras categorías aquí
}



