namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Alipiopsitta;

/// <summary>
/// Interface defining characteristics of Alipiopsitta (genus).
/// </summary>
public interface IAlipiopsitta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
