namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Catharopeza;

/// <summary>
/// Interface defining characteristics of Catharopeza (genus).
/// </summary>
public interface ICatharopeza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
