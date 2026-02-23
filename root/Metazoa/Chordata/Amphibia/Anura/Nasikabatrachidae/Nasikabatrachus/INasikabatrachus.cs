namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nasikabatrachidae.Nasikabatrachus;

/// <summary>
/// Interface defining characteristics of Nasikabatrachus (genus).
/// </summary>
public interface INasikabatrachus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
