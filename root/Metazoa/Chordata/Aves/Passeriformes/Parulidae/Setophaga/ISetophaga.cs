namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Setophaga;

/// <summary>
/// Interface defining characteristics of Setophaga (genus).
/// </summary>
public interface ISetophaga
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
