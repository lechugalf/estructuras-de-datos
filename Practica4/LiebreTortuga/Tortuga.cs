namespace LiebreTortuga
{
    class Tortuga : Corredor
    {
        public Tortuga(string nombre) : base(nombre)
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
                if(condition <= 5)
                {
                    pasos += 3;
                    paso = true;
                }

                else if(condition <= 3)
                {
                    pasos++;
                    paso = true;
                }

                else if(condition <= 2 && pasos >= 6)
                {
                    pasos -= 6;
                    paso = true;
                }
            }
        }

        public override string ToString() 
        {
            return "Tortuga esta en paso " + pasos;
        }
    }
}