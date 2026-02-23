namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Vermivora;

/// <summary>
/// Interface defining characteristics of Vermivora (genus).
/// </summary>
public interface IVermivora
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
