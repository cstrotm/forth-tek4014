\ graphics primitives

: line ( x2 y2 x1 y1 -- )
  GS at at US ;

: rectangle ( x y xw yw -- ) 
  GS
  2 pick +
  swap 3 pick + swap
  2over 2over swap drop 2 pick swap line
  2over 2over drop over line
  2over swap drop 2 pick swap 2over line
  rot drop swap over line
  US
;

: square ( x y w -- )
  dup rectangle ;

: filled-rectangle ( x y xw yw -- )
  GS
  2 pick +
  swap 3 pick + swap
  dup 3 pick do
    3 pick i 3 pick i line
  loop
  2drop 2drop
  US
;
