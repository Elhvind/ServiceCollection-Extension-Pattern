# Bad Example

## Pros

- ingen?

## Cons

- Alle implementeringer skal v�re public da de skal v�re tilg�ngelige under registreringen til DI
- Alle interne modeller, services osv skal ogs� v�re public
- Bliver der i forbindelse med en ny version af pakken udviklet en ny intern klasse, s� vil alle applikationer der bruger pakken blive tvunget til at forholde sig til den, da det er applikationens ansvar at registrere den og ikke pakken
- Opdager f�rst manglende indstillinger under runtime - n�r koden rammes
