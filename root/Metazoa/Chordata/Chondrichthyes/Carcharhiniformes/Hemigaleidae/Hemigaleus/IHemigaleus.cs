namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae.Hemigaleus;

/// <summary>
/// Interface defining characteristics of Hemigaleus (genus).
/// </summary>
public interface IHemigaleus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
