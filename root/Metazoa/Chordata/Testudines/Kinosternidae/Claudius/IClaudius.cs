namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Claudius;

/// <summary>
/// Interface defining characteristics of Claudius (genus).
/// </summary>
public interface IClaudius
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
