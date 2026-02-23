namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Homo;

/// <summary>
/// Interface defining characteristics of Homo (genus).
/// </summary>
public interface IHomo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
