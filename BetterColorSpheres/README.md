```Mermaid
      ClassDiagram
            class Color {
                 - _red: byte 
                 - _green: byte 
                 - _blue: byte 
                 - _alpha: byte 
                 - _alphaDef: byte
                 + GetRed: byte
                 + GetGreen: byte
                 + GetBlue: byte
                 + GetAlpha: byte
                 + GetGrey: byte
            }
            class Sphere {
                  - _color: Color
                  -_radius: float
                  - _n: int
                  - _nDef: int
                  + GetTimesThrown
                  + Pop(): float
                  + Throw(): int
            }
```