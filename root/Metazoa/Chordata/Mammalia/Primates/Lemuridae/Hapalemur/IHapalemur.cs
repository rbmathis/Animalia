namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Hapalemur;

/// <summary>
/// Interface defining characteristics of Hapalemur (genus).
/// </summary>
public interface IHapalemur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
