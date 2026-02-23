namespace AnimalKingdom.root.Metazoa.Chordata.Hyperoartia.Petromyzontiformes.Petromyzontidae.Ichthyomyzon;

/// <summary>
/// Interface defining characteristics of Ichthyomyzon (genus).
/// </summary>
public interface IIchthyomyzon
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
