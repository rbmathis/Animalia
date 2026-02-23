namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pan;

/// <summary>
/// Interface defining characteristics of Pan (genus).
/// </summary>
public interface IPan
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
