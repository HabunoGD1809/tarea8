public class Persona
{
         public string Cedula { get; set; } = "";
         public string Nombres { get; set; } = "";
         public string Apellido1 { get; set; } = "";
         public string Apellido2 { get; set; } = "";
         public string FechaNacimiento { get; set; } = "";
         public string LugarNacimiento { get; set; } = "";
         public string IdSexo { get; set; } = "";
         public string IdEstadoCivil { get; set; } = "";
         public string IDEstatus { get; set; } = "";
         public object EstatusCedulaAzul { get; set; } = "";
         public object CedulaAnterior { get; set; } = "";
         public bool ok { get; set; }
         public string foto { get; set; } = "";
         public int edad()
         {
                  var FechaNacimiento = DateTime.Parse(this.FechaNacimiento);
                  var FechaActual = DateTime.Now;

                  int edad = FechaActual.Year - FechaNacimiento.Year;
                  return edad;
         }
         public string fecha()
         {
                  var FechaNacimiento = DateTime.Parse(this.FechaNacimiento);
                  string date = FechaNacimiento.ToString("dd/MM/yyyy");

                  return date;
         }
		public string SignoZodiacal()
		{
				var FechaNacimiento = DateTime.Parse(this.FechaNacimiento);
				var FechaActual = DateTime.Now;
				string signo = "";

				int mes = FechaNacimiento.Month;
				int dia = FechaNacimiento.Day;
				switch (mes)
				{
		case 1:
				if (dia > 21)
				{
					signo = "ACUARIO";
				}
				else
				{
					signo = "CAPRICORNIO";
				}
				break;
		case 2:
				if (dia > 19)
				{
					signo = "PISCIS";
				}
				else
				{
					signo = "ACUARIO";
				}
				break;
		case 3:
				if (dia > 20)
				{
					signo = "ARIES";
				}
				else
				{
					signo = "PISCIS";
				}
				break;
		case 4:
				if (dia > 20)
				{
					signo = "TAURO";
				}
				else
				{
					signo = "ARIES";
				}
				break;
		case 5:
				if (dia > 21)
				{
					signo = "GEMINIS";
				}
				else
				{
					signo = "TAURO";
				}
				break;
		case 6:
				if (dia > 20)
				{
					signo = "CANCER";
				}
				else
				{
					signo = "GEMINIS";
				}
				break;
		case 7:
				if (dia > 22)
				{
					signo = "LEO";
				}
				else
				{
					signo = "CANCER";
				}
				break;
		case 8:
				if (dia > 21)
				{
					signo = "VIRGO";
				}
				else
				{
					signo = "LEO";
				}
				break;
		case 9:
				if (dia > 22)
				{
					signo = "LIBRA";
				}
				else
				{
					signo = "VIRGO";
				}
				break;
		case 10:
				if (dia > 22)
				{
					signo = "ESCORPION";
				}
				else
				{
					signo = "LIBRA";
				}
				break;
		case 11:
				if (dia > 21)
				{
					signo = "SAGITARIO";
				}
				else
				{
					signo = "ESCORPION";
				}
				break;
		case 12:
				if (dia > 21)
				{
					signo = "CAPRICORNIO";
				}
				else
				{
					signo = "SAGITARIO";
				}
				break;
				}
			return signo;
         }
}

