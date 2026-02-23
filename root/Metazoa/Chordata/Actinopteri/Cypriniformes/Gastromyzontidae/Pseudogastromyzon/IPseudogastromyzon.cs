namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Pseudogastromyzon;

/// <summary>
/// Interface defining characteristics of Pseudogastromyzon (genus).
/// </summary>
public interface IPseudogastromyzon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
