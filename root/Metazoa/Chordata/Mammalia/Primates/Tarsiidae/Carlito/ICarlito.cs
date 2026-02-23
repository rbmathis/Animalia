namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Tarsiidae.Carlito;

/// <summary>
/// Interface defining characteristics of Carlito (genus).
/// </summary>
public interface ICarlito
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
