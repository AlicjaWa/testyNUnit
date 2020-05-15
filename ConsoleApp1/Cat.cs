using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ConsoleApp1
{
    public class Cat
    {
        private String breed;
        private int age;
        private TypeOfFur typeOfFur;

        public Boolean setBreed(String newBreed) {
            if (newBreed == "Persian")
            {
                this.breed = newBreed;
                return true;
            }
            else {
                return false;
            }

        }


        public String getBreed() {
            return breed;
        }

        public void setAge(int age) {
            if (age > 0 && age < 20)
            {
                this.age = age;
            }
            else { 
                throw new ArgumentException("Age is not valid!");
            }
        }

        public void setTypeOfFur (TypeOfFur typeOfFur)
        {
            this.typeOfFur = TypeOfFur.SHORT;
            this.typeOfFur = TypeOfFur.BALD;
            this.typeOfFur = TypeOfFur.LONG;

        }
        public TypeOfFur getTypeOfFur()
        {
            return this.typeOfFur;
        }

        public int getAge() {
            return age;
        }
    }
}
