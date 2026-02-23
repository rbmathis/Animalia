namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Leptopterus;

/// <summary>
/// Interface defining characteristics of Leptopterus (genus).
/// </summary>
public interface ILeptopterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
