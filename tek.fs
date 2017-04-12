vocabulary tek4014
tek4014 definitions

decimal

: ESC $1b emit ;
: FF  $0c emit ; ( Formfeed, erase screen, Home cursor )
: CAN $18 emit ; ( Return to text terminal, only if in sub-Tek )
: FS  $1c emit ; ( Enter point plotting mode )
: GS  $1d emit ; ( Enter line drawing mode )
: US  $1f emit ; ( Enter Tek text mode [leave line/point drawing] )

1 constant red
2 constant green
4 constant blue

: page ESC 12 emit ;

' page alias cls

: tek-on   ESC ." [?38h" ;
: tek-off  ESC ." [?38l" ;

: at ( x y -- )
  dup 32 /   32 + emit
      32 mod 96 + emit
  dup 32 /   32 + emit
      32 mod 64 + emit ;

: color ( c -- )
  ESC ." [1;3" 48 + emit 109 emit ;
        

