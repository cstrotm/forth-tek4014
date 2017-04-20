vocabulary tek4014
tek4014 definitions

decimal

: ESC $1b emit ;
: FF  $0c emit ; ( Formfeed, erase screen, Home cursor )
: CAN $18 emit ; ( Return to text terminal, only if in sub-Tek )
: FS  $1c emit ; ( Enter point plotting mode )
: GS  $1d emit ; ( Enter line drawing mode )
: RS  $1e emit ; ( Enter incremental line drawing mode )
: US  $1f emit ; ( Enter Tek text mode [leave line/point drawing] )

1 constant red
2 constant green
4 constant blue

variable boldf
boldf off

: page ESC FF ;

' page alias cls

: tek-on   ESC ." [?38h" ;
: tek-off  ESC ." [?38l" ;

: penup   RS space ;
: pendown RS 80 emit ;

: east  RS 65 emit ; ( A )
: west  RS 66 emit ; ( B )
: north RS 68 emit ; ( D )
: ne    RS 69 emit ; ( E )
: nw    RS 70 emit ; ( F )
: south RS 72 emit ; ( H )
: se    RS 73 emit ; ( I )
: sw    RS 74 emit ; ( J )

: bold ( toggles bold flag )
  boldf @ invert boldf ! ;

: solid     ESC boldf @ if 104 else 103 then emit ;
: dotted    ESC boldf @ if 105 else  97 then emit ;
: dotdash   ESC boldf @ if 106 else  98 then emit ;
: shortdash ESC boldf @ if 107 else  99 then emit ;
: longdash  ESC boldf @ if 108 else 100 then emit ;

: at ( x y -- )
  dup 32 /   32 + emit
      32 mod 96 + emit
  dup 32 /   32 + emit
      32 mod 64 + emit ;

: plot ( x y -- )
  FS at ;
  
: color ( c -- )
  ESC ." [1;3" 48 + emit 109 emit ;

: large   ESC 56 emit ;
: medium  ESC 57 emit ;
: small   ESC 58 emit ;
: tiny    ESC 59 emit ;
  
