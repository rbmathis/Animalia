namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anabantiformes.Nandidae.Nandus;

/// <summary>
/// Interface defining characteristics of Nandus (genus).
/// </summary>
public interface INandus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
