% Solution for the map coloring problem as described in Figure 5.1.
% A map is depicted with 5 countries A, B, C, D, and E. The goal is to
% colour the countries on the map using just the colours red, white, and
% blue in such a way that no countries with a border between them have
% the same color.
% solution(A,B,C,D,E) holds if A,B,C,D,E are colours that solve the
% described map colouring problem. This is a particular example of the
% general class called 'constraint satisfaction problems'.

print_colors :- solution(A,B,C,D,E),nl,write('Country A is colored:  '), write(A)
                                   ,nl,write('Country B is colored:  '), write(B)
                                   ,nl,write('Country C is colored:  '), write(C)
                                   ,nl,write('Country D is colored:  '), write(D)
                                   ,nl,write('Country E is colored:  '), write(E).

solution(A,B,C,D,E) :- color(A), color(B), color(C), color(D), color(E),
                       \+ A=B, \+ A=C, \+ A=D, \+ A=E, \+ B=C, \+ C=D, \+ D=E.

% The three colours are these:
color(red).
color(white).
color(blue).
