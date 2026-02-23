namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Passerellidae.Melozone;

/// <summary>
/// Interface defining characteristics of Melozone (genus).
/// </summary>
public interface IMelozone
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
