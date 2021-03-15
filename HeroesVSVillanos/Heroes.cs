namespace HeroesVSVillanos
{
    class Heroe : Personaje
    {
        public Heroe(string nombre, string identidadSecreta)
        {
            Nombre = nombre;
            identidadSecreta = identidadSecreta;
        }
        public void OtorgarSuperPoderes()
        {
            volar = true;
            SuperFuerza = true;

            if (nombre =="Batman")
            {
                Millonario = true;
            }
        }

        public void RevocarPoderes()
        {
            volar = false;
            SuperFuerza = false;

        }
    }
}