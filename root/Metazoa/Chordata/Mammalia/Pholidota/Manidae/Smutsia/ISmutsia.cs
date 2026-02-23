namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Smutsia;

/// <summary>
/// Interface defining characteristics of Smutsia (genus).
/// </summary>
public interface ISmutsia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
