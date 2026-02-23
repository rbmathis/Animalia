namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Soricidae.Suncus;

/// <summary>
/// Interface defining characteristics of Suncus (genus).
/// </summary>
public interface ISuncus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
