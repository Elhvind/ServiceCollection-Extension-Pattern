# Good Example

## Pros

- Let at "installere"
- Kontrol over indstillinger under registreringen af pakkens funktionalitet
    - Pakken forventer ikke specifikke n�gler i `appsettings` aka. "magi"
    - Verificering af indstillinger ved opstart
- Pakken udstiller kun kontrakterne til funktionaliteten
    - Alt andet er `internal`
    - Man sikrer sig at interne v�rkt�jer ikke bliver misbrugt
- Skal ikke bekymre sig om interne �ndringer i pakken ved ny version
    - Let at refaktorere pakken s� l�nge kontrakterne er u�ndrede

## Cons

- Flere filer
