namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Emydidae.Clemmys;

/// <summary>
/// Interface defining characteristics of Clemmys (genus).
/// </summary>
public interface IClemmys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
