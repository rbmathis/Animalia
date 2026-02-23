namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Chlamyphoridae.Calyptophractus;

/// <summary>
/// Interface defining characteristics of Calyptophractus (genus).
/// </summary>
public interface ICalyptophractus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
