namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Pseudohemiculter;

/// <summary>
/// Interface defining characteristics of Pseudohemiculter (genus).
/// </summary>
public interface IPseudohemiculter
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
