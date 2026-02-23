namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Trichonotidae.Trichonotus;

/// <summary>
/// Interface defining characteristics of Trichonotus (genus).
/// </summary>
public interface ITrichonotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
