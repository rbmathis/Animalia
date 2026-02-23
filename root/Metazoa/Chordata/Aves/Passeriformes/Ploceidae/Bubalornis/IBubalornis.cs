namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ploceidae.Bubalornis;

/// <summary>
/// Interface defining characteristics of Bubalornis (genus).
/// </summary>
public interface IBubalornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
