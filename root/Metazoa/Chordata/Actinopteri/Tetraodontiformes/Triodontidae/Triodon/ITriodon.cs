namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Triodontidae.Triodon;

/// <summary>
/// Interface defining characteristics of Triodon (genus).
/// </summary>
public interface ITriodon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
