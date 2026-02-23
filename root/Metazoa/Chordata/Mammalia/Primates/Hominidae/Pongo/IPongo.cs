namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Hominidae.Pongo;

/// <summary>
/// Interface defining characteristics of Pongo (genus).
/// </summary>
public interface IPongo
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
