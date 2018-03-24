namespace LiebreTortuga
{
    class Liebre : Corredor
    {
        public Liebre(string nombre) : base(nombre)
        {
            this.pasos = 0;
        }

        public override void correr() 
        {
            bool paso = false;
            int condition = 0;

            while (!paso)
            {
                condition = rand.Next(1, 11);

                // 10% avanza retrocede 12 pasos 
                if(condition <= 1 && pasos >= 12)
                {
                    pasos -= 12;
                    paso = true;
                }

                // 30% avanza 1 paso
                else if(condition <= 3) 
                {
                    pasos += 1;
                    paso = true;
                }

                // 20% 3 opciones
                else if(condition <= 2)
                {
                    condition = rand.Next(3);

                    if(condition < 3) 
                    {
                        pasos += 9;
                        paso = true;
                    }

                    else if(condition <= 2 && pasos >= 2)
                    {
                        pasos -= 2;
                        paso = true;
                    }
                    else
                        paso = true;
                }
            }
        }

        public override string ToString()
        {
            return "Liebre esta en paso " + pasos;
        }
    }
}