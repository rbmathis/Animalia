namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Aptornithidae.Aptornis;

/// <summary>
/// Interface defining characteristics of Aptornis (genus).
/// </summary>
public interface IAptornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
