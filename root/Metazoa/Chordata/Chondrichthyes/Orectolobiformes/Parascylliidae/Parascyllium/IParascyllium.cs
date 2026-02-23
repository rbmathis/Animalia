namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Parascylliidae.Parascyllium;

/// <summary>
/// Interface defining characteristics of Parascyllium (genus).
/// </summary>
public interface IParascyllium
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
