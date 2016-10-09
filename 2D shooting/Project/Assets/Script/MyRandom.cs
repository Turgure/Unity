using System;

class MyRandom {
	private static Random r = new Random(Environment.TickCount);

	public static int nextInt(int min, int max) {
		return r.Next(min, max);
	}

	public static float nextDouble(float range) {
		return (float)(r.NextDouble() - 0.5) * 2 * range;
	}
}
