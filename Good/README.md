# Good Example

## Pros

- Let at "installere"
- Kontrol over indstillinger under registreringen af pakkens funktionalitet
    - Pakken forventer ikke specifikke nøgler i `appsettings` aka. "magi"
    - Verificering af indstillinger ved opstart
- Pakken udstiller kun kontrakterne til funktionaliteten
    - Alt andet er `internal`
    - Man sikrer sig at interne værktøjer ikke bliver misbrugt
- Skal ikke bekymre sig om interne ændringer i pakken ved ny version
    - Let at refaktorere pakken så længe kontrakterne er uændrede

## Cons

- Flere filer
