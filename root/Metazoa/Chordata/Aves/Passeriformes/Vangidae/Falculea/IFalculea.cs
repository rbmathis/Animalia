namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Falculea;

/// <summary>
/// Interface defining characteristics of Falculea (genus).
/// </summary>
public interface IFalculea
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
