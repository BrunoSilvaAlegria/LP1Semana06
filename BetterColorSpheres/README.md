``` Mermaid
classDiagram
      class Color {
                 - _red: byte
                 -_green: byte
                 - _blue: byte
                 -_alpha: byte
                 - _alphaDef: byte
                 + GetRed: byte
                 + GetGreen: byte
                 + GetBlue: byte
                 + GetAlpha: byte
                 + GetGrey: byte
            }
            class Sphere {
                  -_color: Color
                  -_radius: float
                  -_n: int
                  - _nDef: int
                  + GetTimesThrown
                  + Pop(): float
                  + Throw(): int
            }
            class Program {
                  green: Color
                  sphere_green: Sphere
                  blue: Color
                  sphere_blue: Sphere
                  red: Color
                  sphere_red: Sphere
                  color1: Color
                  sphere_color1: Sphere
            }

            Program --> Color
            Program --> Sphere
```
