namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lorisidae.Perodicticus;

/// <summary>
/// Interface defining characteristics of Perodicticus (genus).
/// </summary>
public interface IPerodicticus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
