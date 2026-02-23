namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Cacicus;

/// <summary>
/// Interface defining characteristics of Cacicus (genus).
/// </summary>
public interface ICacicus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
