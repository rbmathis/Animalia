namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Hexanchidae.Hexanchus;

/// <summary>
/// Interface defining characteristics of Hexanchus (genus).
/// </summary>
public interface IHexanchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
