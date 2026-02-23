namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Melogale;

/// <summary>
/// Interface defining characteristics of Melogale (genus).
/// </summary>
public interface IMelogale
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
