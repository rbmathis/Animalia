namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Podocnemididae.Erymnochelys;

/// <summary>
/// Interface defining characteristics of Erymnochelys (genus).
/// </summary>
public interface IErymnochelys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
