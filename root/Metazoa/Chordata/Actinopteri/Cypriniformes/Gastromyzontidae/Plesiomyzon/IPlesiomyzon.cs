namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Plesiomyzon;

/// <summary>
/// Interface defining characteristics of Plesiomyzon (genus).
/// </summary>
public interface IPlesiomyzon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
