namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Beamys;

/// <summary>
/// Interface defining characteristics of Beamys (genus).
/// </summary>
public interface IBeamys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
