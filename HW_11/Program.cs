using System;
using System.Collections;
using System.Collections.Generic;

// Завдання 1: Океанаріум
// Класс морська істота
public class SeaPet
{
    public string Name { get; set; }
    public string Opys { get; set; }//опис

    public SeaPet(string name, string opys)
    {
        Name = name;
        Opys = opys;
    }
}

// Клас океанаріум
public class Oceanarium : IEnumerable<SeaPet>
{
    private List<SeaPet> inhabitants;

    public Oceanarium()
    {
        inhabitants = new List<SeaPet>();
    }

    public void AddCreature(string name, string opys)
    {
        inhabitants.Add(new SeaPet(name, opys));
    }

    public IEnumerator<SeaPet> GetEnumerator()
    {
        return inhabitants.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Завдання 2: Футбольна Команда
// Клас гравець
public class FootballPlayer
{
    public string Name { get; set; }
    public int Number { get; set; }

    public FootballPlayer(string name, int number)
    {
        Name = name;
        Number = number;
    }
}

// Клас команда
public class FootballTeam : IEnumerable<FootballPlayer>
{
    private List<FootballPlayer> players;

    public FootballTeam()
    {
        players = new List<FootballPlayer>();
    }

    public void AddPlayer(string name, int number)
    {
        players.Add(new FootballPlayer(name, number));
    }

    public IEnumerator<FootballPlayer> GetEnumerator()
    {
        return players.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Oceanarium oceanarium = new Oceanarium();
        oceanarium.AddCreature("Дельфiн", "Грацiйно стрибає");
        oceanarium.AddCreature("Акула", "Має вражаючi зуби");
        oceanarium.AddCreature("Кит", "Величезний велетень");


        Console.WriteLine("Мешканцi океанарiуму:");
        foreach (var creature in oceanarium)
        {
            Console.WriteLine($"Iм'я: {creature.Name},\tОпис: {creature.Opys}");
        }


        FootballTeam team = new FootballTeam();
        team.AddPlayer("Петро", 10);
        team.AddPlayer("Iван", 7);
        team.AddPlayer("Олексiй", 5);

        Console.WriteLine("\nГравцi футбольної команди:");
        foreach (var player in team)
        {
            Console.WriteLine($"Iм'я: {player.Name},\tНомер: {player.Number}");
        }
    }
}
