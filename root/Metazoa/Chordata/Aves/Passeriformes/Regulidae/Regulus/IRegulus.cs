namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Regulidae.Regulus;

/// <summary>
/// Interface defining characteristics of Regulus (genus).
/// </summary>
public interface IRegulus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
