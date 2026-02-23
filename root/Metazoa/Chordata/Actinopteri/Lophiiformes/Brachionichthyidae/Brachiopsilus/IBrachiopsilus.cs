namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Brachionichthyidae.Brachiopsilus;

/// <summary>
/// Interface defining characteristics of Brachiopsilus (genus).
/// </summary>
public interface IBrachiopsilus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
