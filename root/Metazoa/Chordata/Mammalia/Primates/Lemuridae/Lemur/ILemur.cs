namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Lemur;

/// <summary>
/// Interface defining characteristics of Lemur (genus).
/// </summary>
public interface ILemur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
