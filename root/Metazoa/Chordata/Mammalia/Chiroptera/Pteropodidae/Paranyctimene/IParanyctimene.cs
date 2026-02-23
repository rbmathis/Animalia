namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Paranyctimene;

/// <summary>
/// Interface defining characteristics of Paranyctimene (genus).
/// </summary>
public interface IParanyctimene
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
