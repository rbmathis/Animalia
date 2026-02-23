namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Anodonthyla;

/// <summary>
/// Interface defining characteristics of Anodonthyla (genus).
/// </summary>
public interface IAnodonthyla
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
