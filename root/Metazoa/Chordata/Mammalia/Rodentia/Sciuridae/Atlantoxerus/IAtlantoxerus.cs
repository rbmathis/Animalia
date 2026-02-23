namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Atlantoxerus;

/// <summary>
/// Interface defining characteristics of Atlantoxerus (genus).
/// </summary>
public interface IAtlantoxerus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
