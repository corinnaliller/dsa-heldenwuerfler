using System;

namespace Heldenwuerfler

public class Wuerfel
{
	private int seiten;
	private Random random;

	public Wuerfel(int seiten)
	{
		this.seiten = seiten;
		this.random = new Random(seiten);
	}
	public int Wuerfeln()
	{
		return random.Next(1, seiten);
	}
}
