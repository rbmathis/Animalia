namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Solenodontidae.Solenodon;

/// <summary>
/// Interface defining characteristics of Solenodon (genus).
/// </summary>
public interface ISolenodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
