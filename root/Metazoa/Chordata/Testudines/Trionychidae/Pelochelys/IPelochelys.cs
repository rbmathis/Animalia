namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelochelys;

/// <summary>
/// Interface defining characteristics of Pelochelys (genus).
/// </summary>
public interface IPelochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
