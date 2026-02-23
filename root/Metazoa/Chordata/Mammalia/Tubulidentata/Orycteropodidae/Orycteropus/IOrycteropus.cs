namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Tubulidentata.Orycteropodidae.Orycteropus;

/// <summary>
/// Interface defining characteristics of Orycteropus (genus).
/// </summary>
public interface IOrycteropus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
