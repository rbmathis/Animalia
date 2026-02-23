namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Helmitheros;

/// <summary>
/// Interface defining characteristics of Helmitheros (genus).
/// </summary>
public interface IHelmitheros
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
