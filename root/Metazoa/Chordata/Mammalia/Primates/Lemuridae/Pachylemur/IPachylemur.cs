namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Pachylemur;

/// <summary>
/// Interface defining characteristics of Pachylemur (genus).
/// </summary>
public interface IPachylemur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
