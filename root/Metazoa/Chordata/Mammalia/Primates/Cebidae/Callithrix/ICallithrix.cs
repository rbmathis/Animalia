namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Callithrix;

/// <summary>
/// Interface defining characteristics of Callithrix (genus).
/// </summary>
public interface ICallithrix
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
