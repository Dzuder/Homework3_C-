﻿using static System.Console;
WriteLine("Point A-> Enter 'x' coordinate: ");
int.TryParse(ReadLine(), out int Ax);
WriteLine("Point A-> Enter 'y' coordinate: ");
int.TryParse(ReadLine(), out int Ay);
WriteLine("Point A-> Enter 'z' coordinate: ");
int.TryParse(ReadLine(), out int Az);
WriteLine("Point B-> Enter 'x' coordinate: ");
int.TryParse(ReadLine(), out int Bx);
WriteLine("Point B-> Enter 'y' coordinate: ");
int.TryParse(ReadLine(), out int By);
WriteLine("Point B-> Enter 'z' coordinate: ");
int.TryParse(ReadLine(), out int Bz);
WriteLine(Math.Sqrt(Math.Pow((Ax - Bx), 2) + Math.Pow((Ay - By), 2) + Math.Pow((Az - Bz), 2)));