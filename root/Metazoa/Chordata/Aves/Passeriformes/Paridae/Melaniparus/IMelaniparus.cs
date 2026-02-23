namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Melaniparus;

/// <summary>
/// Interface defining characteristics of Melaniparus (genus).
/// </summary>
public interface IMelaniparus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
