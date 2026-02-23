namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Brachionichthyidae.Brachionichthys;

/// <summary>
/// Interface defining characteristics of Brachionichthys (genus).
/// </summary>
public interface IBrachionichthys
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
