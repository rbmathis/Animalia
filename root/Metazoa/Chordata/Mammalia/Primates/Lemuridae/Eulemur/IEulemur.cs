namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Lemuridae.Eulemur;

/// <summary>
/// Interface defining characteristics of Eulemur (genus).
/// </summary>
public interface IEulemur
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
