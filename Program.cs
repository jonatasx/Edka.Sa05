            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

            namespace Edka.Sa05
            {
                internal class Program
                {
                    public static List<Disciplina> disciplinas = new List<Disciplina>
                        {
                            //Lista Genérica < >
                            new Disciplina{Descricao="Neurociência e aprendizagem",Inicio= new DateTime(2022,08,08),Termino= new DateTime(2022,09,12)},
                            new Disciplina{Descricao="Habilidade socio emocionais",Inicio= new DateTime(2022,08,10),Termino= new DateTime(2022,08,24)},
                            new Disciplina{Descricao="Felicidade",Inicio= new DateTime(2022,08,31),Termino= new DateTime(2022,09,14)},
                             new Disciplina{Descricao="Teoria do Desenvolvimento Humano e da Aprendizagem",Inicio= new DateTime(2022,09,19),Termino= new DateTime(2022,10,24)},
                              new Disciplina{Descricao="Planejamento Pedagógico",Inicio= new DateTime(2022,08,27),Termino= new DateTime(2022,10,23)},
                               new Disciplina{Descricao="Educação inclusiva e Cidadania",Inicio= new DateTime(2022,09,21),Termino= new DateTime(2022,11,09)},
                                new Disciplina{Descricao="Gestão da Sala de Aula",Inicio= new DateTime(2022,11,16),Termino= new DateTime(2022,12,30)},
                                 new Disciplina{Descricao="Met. Dinâmicas e Inovativas",Inicio= new DateTime(2022,10,31),Termino= new DateTime(2022,11,14)},
                                  new Disciplina{Descricao="Projeto Integrador",Inicio= new DateTime(2022,11,21),Termino= new DateTime(2022,12,05)},
                                   new Disciplina{Descricao="Avaliação Por Competências",Inicio= new DateTime(2023,01,01),Termino= new DateTime(2023,01,02)},
                                    new Disciplina{Descricao="Aprendizagem por Competências",Inicio= new DateTime(2022,01,02),Termino= new DateTime(2022,01,03)},
                                     new Disciplina{Descricao="Prática Docente à Distância",Inicio= new DateTime(2022,01,03),Termino= new DateTime(2022,01,04)},
                                      new Disciplina{Descricao="Legislação e diretrizes da Educação Profissinal e tecnológica",Inicio= new DateTime(2022,01,04),Termino= new DateTime(2022,01,05)},
                                       new Disciplina{Descricao="Ambientes de Aprendizagem Inovativos",Inicio= new DateTime(2022,01,05),Termino= new DateTime(2022,01,06)}



                        };
                    static void Main(string[] args)
                    {
                        //Filtro LINQ
                        //from
                        //in
                        //select

                        var dataOrdenada = from d in disciplinas
                                     
                                                  orderby d.Inicio ascending
                                     
                                                  select d;

                        foreach (var item in dataOrdenada)
                        {
                            Console.WriteLine(item);

                        }

                        Console.ReadKey();
                    }
                }
            }

