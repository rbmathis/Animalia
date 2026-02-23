namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Procyonidae.Nasua;

/// <summary>
/// Interface defining characteristics of Nasua (genus).
/// </summary>
public interface INasua
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
