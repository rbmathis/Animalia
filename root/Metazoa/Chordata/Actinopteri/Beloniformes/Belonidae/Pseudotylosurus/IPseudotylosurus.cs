namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beloniformes.Belonidae.Pseudotylosurus;

/// <summary>
/// Interface defining characteristics of Pseudotylosurus (genus).
/// </summary>
public interface IPseudotylosurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
