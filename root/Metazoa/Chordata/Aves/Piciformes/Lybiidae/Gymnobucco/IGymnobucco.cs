namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Lybiidae.Gymnobucco;

/// <summary>
/// Interface defining characteristics of Gymnobucco (genus).
/// </summary>
public interface IGymnobucco
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
