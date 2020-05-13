using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CodeWars._5kyu
{
    public class Dinglemouse
    {
        private int _age;
        private char _sex;
        private string _name;
        private List<char> _invokingQueue = new List<char>();

        public Dinglemouse SetAge(int age)
        {
            _prettyUselessMethod('A');
            _age = age;
            return this;
        }

        public Dinglemouse SetSex(char sex)
        {
            _prettyUselessMethod('S');
            _sex = sex;
            return this;
        }

        public Dinglemouse SetName(string name)
        {
            _prettyUselessMethod('N');
            _name = name;
            return this;
        }

        private void _prettyUselessMethod(char type)
        {
            if (_invokingQueue.Contains(type))
            {
                _invokingQueue.Remove(type);
                _invokingQueue.Add(type);
            }
            else
            {
                _invokingQueue.Add(type);
            }
        }

        public string Hello()
        {
            StringBuilder coolStoryBuilder = new StringBuilder();
            coolStoryBuilder.Append("Hello.");
            foreach(char method in _invokingQueue)
            {
                switch(method)
                {
                    case 'A': coolStoryBuilder.Append($" I am {_age}."); break;
                    case 'S': coolStoryBuilder.Append($" I am {(_sex == 'M' ? "male" : "female")}."); break;
                    case 'N': coolStoryBuilder.Append($" My name is {_name}."); break;
                }
            }
            return coolStoryBuilder.ToString();
        }
    }
}
