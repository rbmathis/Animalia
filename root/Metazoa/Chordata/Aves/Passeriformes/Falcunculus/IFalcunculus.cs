namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Falcunculus;

/// <summary>
/// Interface defining characteristics of Falcunculus (genus).
/// </summary>
public interface IFalcunculus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
