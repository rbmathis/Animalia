namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Teretistris;

/// <summary>
/// Interface defining characteristics of Teretistris (genus).
/// </summary>
public interface ITeretistris
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
