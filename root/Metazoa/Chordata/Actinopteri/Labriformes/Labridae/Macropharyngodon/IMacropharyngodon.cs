namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Macropharyngodon;

/// <summary>
/// Interface defining characteristics of Macropharyngodon (genus).
/// </summary>
public interface IMacropharyngodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
