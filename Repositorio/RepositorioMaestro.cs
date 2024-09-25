using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        public List<Municipio> ObtenerMunicipio()
        {
            var municipio = new List<Municipio>();
            municipio.Add(new Municipio() { Id = 1, Nombre = "Medellín" });
            municipio.Add(new Municipio() { Id = 2, Nombre = "Bello" });
            municipio.Add(new Municipio() { Id = 3, Nombre = "Sabaneta" });

            return municipio;
        }
        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposdocumento = new List<TipoDocumento>();
            tiposdocumento.Add(new TipoDocumento() { Id = 1, Nombre = "CC" });
            tiposdocumento.Add(new TipoDocumento() { Id = 2, Nombre = "TI" });
            tiposdocumento.Add(new TipoDocumento() { Id = 3, Nombre = "Registro Civil" });
            tiposdocumento.Add(new TipoDocumento() { Id = 4, Nombre = "Pasaporte" });
            tiposdocumento.Add(new TipoDocumento() { Id = 5, Nombre = "Pasaporte" });

            return tiposdocumento;
        }
        public List<Departamento> ObtenerDepartamentos()
        {
            var departamentos = new List<Departamento>();
            departamentos.Add(new Departamento() { Id = 1, Nombre = "Amazonas" });
            departamentos.Add(new Departamento() { Id = 2, Nombre = "Antioquia" });
            departamentos.Add(new Departamento() { Id = 3, Nombre = "Arauca" });
            departamentos.Add(new Departamento() { Id = 4, Nombre = "Atlántico" });
            departamentos.Add(new Departamento() { Id = 5, Nombre = "Bolivar" });
            departamentos.Add(new Departamento() { Id = 6, Nombre = "Boyacá" });
            departamentos.Add(new Departamento() { Id = 7, Nombre = "Caldas" });
            departamentos.Add(new Departamento() { Id = 8, Nombre = "Caquetá" });
            departamentos.Add(new Departamento() { Id = 9, Nombre = "Casanare" });
            departamentos.Add(new Departamento() { Id = 10, Nombre = "Cauca" });
            departamentos.Add(new Departamento() { Id = 11, Nombre = "Cesar" });
            departamentos.Add(new Departamento() { Id = 12, Nombre = "Chocó" });
            departamentos.Add(new Departamento() { Id = 13, Nombre = "Córdoba" });
            departamentos.Add(new Departamento() { Id = 14, Nombre = "Cundinamarca" });
            departamentos.Add(new Departamento() { Id = 14, Nombre = "Guainía" });
            departamentos.Add(new Departamento() { Id = 15, Nombre = "Guaviare" });
            departamentos.Add(new Departamento() { Id = 16, Nombre = "Huila" });
            departamentos.Add(new Departamento() { Id = 17, Nombre = "La Guajira" });
            departamentos.Add(new Departamento() { Id = 18, Nombre = "Magdalena" });
            departamentos.Add(new Departamento() { Id = 19, Nombre = "Meta" });
            departamentos.Add(new Departamento() { Id = 20, Nombre = "Nariño" });
            departamentos.Add(new Departamento() { Id = 21, Nombre = "Norte de Santander" });
            departamentos.Add(new Departamento() { Id = 22, Nombre = "Putumayo" });
            departamentos.Add(new Departamento() { Id = 23, Nombre = "Quindío" });
            departamentos.Add(new Departamento() { Id = 24, Nombre = "Risaralda" });
            departamentos.Add(new Departamento() { Id = 25, Nombre = "San Andrés y Providencia" });
            departamentos.Add(new Departamento() { Id = 26, Nombre = "Santander" });
            departamentos.Add(new Departamento() { Id = 27, Nombre = "Sucre" });
            departamentos.Add(new Departamento() { Id = 28, Nombre = "Tolima" });
            departamentos.Add(new Departamento() { Id = 29, Nombre = "Valle del cauca" });
            departamentos.Add(new Departamento() { Id = 30, Nombre = "Vaupés" });
            departamentos.Add(new Departamento() { Id = 31, Nombre = "Vichada" });

            return departamentos;
        }
        public List<Sexo> ObtenerSexos()
        {
            var sexos = new List<Sexo>();
            sexos.Add(new Sexo() { Id = 1, Nombre = "Femenino" });
            sexos.Add(new Sexo() { Id = 2, Nombre = "Masculino" });
            sexos.Add(new Sexo() { Id = 3, Nombre = "No Binario" });
            sexos.Add(new Sexo() { Id = 4, Nombre = "Prefiere no responder" });
            

            return sexos;
        }
        public List<Orientacion> ObtenerOrientacionSexual()
        {
            var orientacionSexual = new List<Orientacion>();
            orientacionSexual.Add(new Orientacion() { Id = 1, Nombre = "Asexual" });
            orientacionSexual.Add(new Orientacion() { Id = 2, Nombre = "Bisexual" });
            orientacionSexual.Add(new Orientacion() { Id = 3, Nombre = "Heterosexual" });
            orientacionSexual.Add(new Orientacion() { Id = 4, Nombre = "Lesbiana" });
            orientacionSexual.Add(new Orientacion() { Id = 5, Nombre = "Pansexual" });
            orientacionSexual.Add(new Orientacion() { Id = 6, Nombre = "Prefiere No Responder" });


            return orientacionSexual;
        }
        public List<IdentidadGenero> ObtenerIdentidadGeneros()
        {
            var identidadGeneros = new List<IdentidadGenero>();
            identidadGeneros.Add(new IdentidadGenero() { Id = 1, Nombre = "Trans Femenino" });
            identidadGeneros.Add(new IdentidadGenero() { Id = 2, Nombre = "Trans Masculino" });
            identidadGeneros.Add(new IdentidadGenero() { Id = 3, Nombre = "Trans No Binario" });
            identidadGeneros.Add(new IdentidadGenero() { Id = 4, Nombre = "Mujer cisgénero" });
            identidadGeneros.Add(new IdentidadGenero() { Id = 5, Nombre = "Hombre cisgénero" });
            identidadGeneros.Add(new IdentidadGenero() { Id = 6, Nombre = "No aplica" });
            identidadGeneros.Add(new IdentidadGenero() { Id = 7, Nombre = "Prefiere no responder" });


            return identidadGeneros;
        }
        public List<Sede> ObtenerSedes()
        {
            var sedes = new List<Sede>();
            sedes.Add(new Sede() { Id = 1, Nombre = "Medellín - Área de la Salud" });
            sedes.Add(new Sede() { Id = 2, Nombre = "Medellín - Ciudad Universitaria" });
            sedes.Add(new Sede() { Id = 3, Nombre = "Seccional Bajo Cauca" });
            sedes.Add(new Sede() { Id = 4, Nombre = "Seccional Magdalena Medio" });
            sedes.Add(new Sede() { Id = 5, Nombre = "Seccional Norte" });
            sedes.Add(new Sede() { Id = 6, Nombre = "Seccional Oriente" });
            sedes.Add(new Sede() { Id = 7, Nombre = "Seccional Urabá" });



            return sedes;
        }
        public List<Facultad> ObtenerFacultades()
        {
            var facultades = new List<Facultad>();
            facultades.Add(new Facultad() { Id = 1, Nombre = "Escuela de Microbiologia" });
            facultades.Add(new Facultad() { Id = 2, Nombre = "Escuela de Nutrición y Dietética" });
            facultades.Add(new Facultad() { Id = 3, Nombre = "Dirección de Bienestar Universitario" });
            facultades.Add(new Facultad() { Id = 4, Nombre = "Dirección de Comunicaciones" });
            facultades.Add(new Facultad() { Id = 5, Nombre = "Dirección de Planeación y Desarrollo Institucional" });
            facultades.Add(new Facultad() { Id = 6, Nombre = "Dirección de Posgrado" });
            facultades.Add(new Facultad() { Id = 7, Nombre = "Dirección de Regionalización" });
            facultades.Add(new Facultad() { Id = 8, Nombre = "Dirección de Relaciones Internacionales" });
            facultades.Add(new Facultad() { Id = 9, Nombre = "Dirección Jurídica" });
            facultades.Add(new Facultad() { Id = 10, Nombre = "Escuela de Idiomas" });
            facultades.Add(new Facultad() { Id = 11, Nombre = "Escuela Interamericana de Bibliotecología" });
            facultades.Add(new Facultad() { Id = 12, Nombre = "Facultad de Artes" });
            facultades.Add(new Facultad() { Id = 13, Nombre = "Facultad de Ciencias Agrarias" });
            facultades.Add(new Facultad() { Id = 14, Nombre = "Facultad de Ciencias Económicas" });
            facultades.Add(new Facultad() { Id = 15, Nombre = "Facultad de Ciencias Exactas y Naturales" });
            facultades.Add(new Facultad() { Id = 16, Nombre = "Facultad de Ciencias Farmacéuticas y Alimentarias" });
            facultades.Add(new Facultad() { Id = 17, Nombre = "Facultad de Ciencias Sociales y Humanas" });
            facultades.Add(new Facultad() { Id = 18, Nombre = "Facultad de Comunicaciones" });
            facultades.Add(new Facultad() { Id = 19, Nombre = "Facultad de Derecho y Ciencias Políticas" });
            facultades.Add(new Facultad() { Id = 20, Nombre = "Facultad de Educación" });
            facultades.Add(new Facultad() { Id = 21, Nombre = "Facultad de Enfermería" });
            facultades.Add(new Facultad() { Id = 22, Nombre = "Facultad de Odontología" });
            facultades.Add(new Facultad() { Id = 23, Nombre = "Facultad Nacional de Salud Pública" });
            facultades.Add(new Facultad() { Id = 24, Nombre = "Instituto de Estudios Políticos" });
            facultades.Add(new Facultad() { Id = 25, Nombre = "Instituto de Estudios Regionales" });
            facultades.Add(new Facultad() { Id = 26, Nombre = "Instituto de Filosofía" });
            facultades.Add(new Facultad() { Id = 27, Nombre = "Instituto Universitario de Educación Física y Deportes" });
            facultades.Add(new Facultad() { Id = 28, Nombre = "Oficina de Auditoría Institucional" });
            facultades.Add(new Facultad() { Id = 29, Nombre = "Rectoría" });
            facultades.Add(new Facultad() { Id = 30, Nombre = "Secretaría General" });
            facultades.Add(new Facultad() { Id = 31, Nombre = "Vicerrectoría Administrativa" });
            facultades.Add(new Facultad() { Id = 32, Nombre = "Vicerrectoría de Docencia" });
            facultades.Add(new Facultad() { Id = 33, Nombre = "Vicerrectoría de Extensión" });
            facultades.Add(new Facultad() { Id = 34, Nombre = "Vicerrectoría de Investigación" });
            facultades.Add(new Facultad() { Id = 35, Nombre = "Vicerrectoría General" });
            facultades.Add(new Facultad() { Id = 36, Nombre = "Facultad de Ingeniería" });
            facultades.Add(new Facultad() { Id = 37, Nombre = "Facultad de Medicina" });
            
            return facultades;
        }
        public List<ViolenciaSexual> ObtenerViolenciaSexuales()
        {
            var violenciasexuales = new List<ViolenciaSexual>();
            violenciasexuales.Add(new ViolenciaSexual() { Id = 1, Nombre = "Acceso carnal violento" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 2, Nombre = "Acto sexual violento" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 3, Nombre = "Explotación sexual: Inducción a la prostitución" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 4, Nombre = "Explotación sexual: Proxenetismo con menor de edad" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 5, Nombre = "Explotación sexual: Constreñimiento a la prostitución" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 6, Nombre = "Explotación sexual: Trata de personas" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 7, Nombre = "Explotación sexual: Estímulo a la prostitución de menores" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 8, Nombre = "Explotación sexual: Demanda de explotación sexual comercial de persona menor de 18 años de edad" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 9, Nombre = "Explotación sexual: Pornografía con personas menores de 18 años" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 10, Nombre = "Acoso Sexual" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 11, Nombre = "Obligar a otra persona a realizar cualquier acto o interacción sexual con tercera persona" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 12, Nombre = "Violencia sexual correctiva" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 13, Nombre = "Violencia sexual facilitada por las nuevas tecnologías: Creación, difusión, distribución o intercambio digital de fotografías, videos o audioclips de naturaleza sexual o íntima sin consentimiento" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 14, Nombre = "Violencia sexual facilitada por las nuevas tecnologías: Amenazas directas de daño o violencia -Sextorsion" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 15, Nombre = "Violencia sexual facilitada por las nuevas tecnologías: Grooming" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 16, Nombre = "Violencia sexual facilitada por las nuevas tecnologías: Sexting sin consentimiento" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 17, Nombre = "Violencia sexual facilitada por las nuevas tecnologías: Abuso, explotación y/o trata de mujeres y niñas por medio de las tecnologías" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 18, Nombre = "Otra" });
            violenciasexuales.Add(new ViolenciaSexual() { Id = 19, Nombre = "No aplica" });



            return violenciasexuales;
        }
        public List<ViolenciaFisica> ObtenerViolenciaFisicas()
        {
            var violenciafisicas = new List<ViolenciaFisica>();
            violenciafisicas.Add(new ViolenciaFisica() { Id = 1, Nombre = "Agresión física" });
            violenciafisicas.Add(new ViolenciaFisica() { Id = 2, Nombre = "Feminicidio tentado o consumado" });
            violenciafisicas.Add(new ViolenciaFisica() { Id = 3, Nombre = "Restricción a la libertad física (no es exclusiva del ámbito familiar)" });
            violenciafisicas.Add(new ViolenciaFisica() { Id = 4, Nombre = "Violencia física facilitada por las nuevas tecnologías" });
            violenciafisicas.Add(new ViolenciaFisica() { Id = 5, Nombre = "Otra" });
            violenciafisicas.Add(new ViolenciaFisica() { Id = 6, Nombre = "No aplica" });



            return violenciafisicas;
        }
        public List<ViolenciaEconomica> ObtenerViolenciaEconomicas()
        {
            var violenciaeconomicas = new List<ViolenciaEconomica>();
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 1, Nombre = "Pérdida, transformación, sustracción, destrucción, retención o distracción de objetos o bienes de la persona" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 2, Nombre = "Pérdida, transformación, sustracción, destrucción, retención o distracción de instrumentos de trabajo de la persona" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 3, Nombre = "Pérdida, transformación, sustracción, destrucción, retención o distracción de documentos personales" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 4, Nombre = "Pérdida, transformación, sustracción, destrucción, retención o distracción de valores o derechos económicos destinados a satisfacer las necesidades de la persona" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 5, Nombre = "Extorsión" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 6, Nombre = "Estafa" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 7, Nombre = "Inasistencia alimentaria" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 8, Nombre = "Control económico" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 9, Nombre = "Violencia económica facilitada por las nuevas tecnologías" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 10, Nombre = "Otra" });
            violenciaeconomicas.Add(new ViolenciaEconomica() { Id = 11, Nombre = "No aplica" });

            return violenciaeconomicas;
        }
        public List<ViolenciaPrejuicio> ObtenerViolenciaPrejuicios()
        {
            var violenciaPrejuicios = new List<ViolenciaPrejuicio>();
            violenciaPrejuicios.Add(new ViolenciaPrejuicio() { Id = 1, Nombre = "Discriminación por género u orientación sexual o identidad de género" });
            violenciaPrejuicios.Add(new ViolenciaPrejuicio() { Id = 2, Nombre = "Hostigamiento" });
            violenciaPrejuicios.Add(new ViolenciaPrejuicio() { Id = 3, Nombre = "Otra" });
            violenciaPrejuicios.Add(new ViolenciaPrejuicio() { Id = 4, Nombre = "No aplica" });



            return violenciaPrejuicios;
        }
        public List<ViolenciaInstitucional> ObtenerViolenciaInstitucional()
        {
            var violenciaInstitucional = new List<ViolenciaInstitucional>();
            violenciaInstitucional.Add(new ViolenciaInstitucional() { Id = 1, Nombre = "Omisión del deber de denuncia" });
            violenciaInstitucional.Add(new ViolenciaInstitucional() { Id = 2, Nombre = "Omisión al deber de debida diligencia" });
            violenciaInstitucional.Add(new ViolenciaInstitucional() { Id = 3, Nombre = "Revictimización" });
            violenciaInstitucional.Add(new ViolenciaInstitucional() { Id = 4, Nombre = "Otra" });
            violenciaInstitucional.Add(new ViolenciaInstitucional() { Id = 5, Nombre = "No aplica" });

            return violenciaInstitucional;
        }
        public List<ActivacionInterna> ObtenerActivacionInterna()
        {
            var activacionInterna = new List<ActivacionInterna>();
            activacionInterna.Add(new ActivacionInterna() { Id = 1, Nombre = "Dupla psico-jurídica" });
            activacionInterna.Add(new ActivacionInterna() { Id = 2, Nombre = "Psicorientación con perspectiva de genero" });
            activacionInterna.Add(new ActivacionInterna() { Id = 3, Nombre = "No acepta/No toma ninguna decisión en esta sesión." });
            activacionInterna.Add(new ActivacionInterna() { Id = 4, Nombre = "No aplica" });

            return activacionInterna;
        }
        public List<RemisionEspecialistas> ObtenerRemisionEspecialistas()
        {
            var remisionEspecialistas = new List<RemisionEspecialistas>();
            remisionEspecialistas.Add(new RemisionEspecialistas() { Id = 1, Nombre = "Psicorientación presencial" });
            remisionEspecialistas.Add(new RemisionEspecialistas() { Id = 2, Nombre = "Psicorientación Línea Bienestar Universitario" });
            remisionEspecialistas.Add(new RemisionEspecialistas() { Id = 3, Nombre = "DTelepsiquiatría" });
            remisionEspecialistas.Add(new RemisionEspecialistas() { Id = 4, Nombre = "Remisión HAMA" });
            remisionEspecialistas.Add(new RemisionEspecialistas() { Id = 5, Nombre = "Carta del millón" });


            return remisionEspecialistas;
        }

        List<Vinculo> IRepositorioMaestro.ObtenerVinculo()
        {
            throw new NotImplementedException();
        }

        List<ViolenciaPsicologica> IRepositorioMaestro.ObtenerViolenciaPsicologicas()
        {
            throw new NotImplementedException();
        }
    }
}
