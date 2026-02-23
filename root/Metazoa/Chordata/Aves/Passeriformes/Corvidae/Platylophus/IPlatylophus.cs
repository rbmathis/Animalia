namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Platylophus;

/// <summary>
/// Interface defining characteristics of Platylophus (genus).
/// </summary>
public interface IPlatylophus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
