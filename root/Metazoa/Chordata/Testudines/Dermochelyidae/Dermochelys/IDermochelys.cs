namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Dermochelyidae.Dermochelys;

/// <summary>
/// Interface defining characteristics of Dermochelys (genus).
/// </summary>
public interface IDermochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
