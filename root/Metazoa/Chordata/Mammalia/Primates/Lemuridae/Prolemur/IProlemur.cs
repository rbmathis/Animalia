namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Prolemur;

/// <summary>
/// Interface defining characteristics of Prolemur (genus).
/// </summary>
public interface IProlemur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
