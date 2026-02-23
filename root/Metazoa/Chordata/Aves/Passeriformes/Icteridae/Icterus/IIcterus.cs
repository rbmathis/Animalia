namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Icterus;

/// <summary>
/// Interface defining characteristics of Icterus (genus).
/// </summary>
public interface IIcterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
