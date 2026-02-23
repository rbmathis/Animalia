namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Gibbonsia;

/// <summary>
/// Interface defining characteristics of Gibbonsia (genus).
/// </summary>
public interface IGibbonsia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
