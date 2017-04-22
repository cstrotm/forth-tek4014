\ turtle extension for graphics primitives

variable turtle-x
variable turtle-y

1024 constant width
1024 constant height

: xy@ ( -- x y )
  turtle-x @ turtle-y @ ;

: xy! ( x y -- )
  turtle-y ! turtle-x ! ;

: xy+! ( x y -- )
  turtle-y +! turtle-x +! ;

: line ( x2 y2 x1 y1 -- )
  2>r
  xy@ 2r@ line
  2r> xy! ;

: rectangle ( w h -- )
  2>r
  xy@ 2r@ rectangle
  2r> xy+! ;

: square ( w -- )
  dup rectangle ;

: filled-rectangle ( w h -- )
  2>r
  xy@ 2r@ filled-rectangle
  2r> xy+!  ;
