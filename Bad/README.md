# Bad Example

## Pros

- ingen?

## Cons

- Alle implementeringer skal være public da de skal være tilgængelige under registreringen til DI
- Alle interne modeller, services osv skal også være public
- Bliver der i forbindelse med en ny version af pakken udviklet en ny intern klasse, så vil alle applikationer der bruger pakken blive tvunget til at forholde sig til den, da det er applikationens ansvar at registrere den og ikke pakken
- Opdager først manglende indstillinger under runtime - når koden rammes
