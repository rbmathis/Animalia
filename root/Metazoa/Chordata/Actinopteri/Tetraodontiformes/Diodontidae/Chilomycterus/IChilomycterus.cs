namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Diodontidae.Chilomycterus;

/// <summary>
/// Interface defining characteristics of Chilomycterus (genus).
/// </summary>
public interface IChilomycterus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
