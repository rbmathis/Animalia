namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Melanochelys;

/// <summary>
/// Interface defining characteristics of Melanochelys (genus).
/// </summary>
public interface IMelanochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
