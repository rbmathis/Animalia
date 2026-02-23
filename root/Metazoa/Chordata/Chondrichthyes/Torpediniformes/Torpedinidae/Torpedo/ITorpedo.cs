namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Torpediniformes.Torpedinidae.Torpedo;

/// <summary>
/// Interface defining characteristics of Torpedo (genus).
/// </summary>
public interface ITorpedo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
