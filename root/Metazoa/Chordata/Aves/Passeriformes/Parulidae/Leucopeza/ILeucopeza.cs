namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Leucopeza;

/// <summary>
/// Interface defining characteristics of Leucopeza (genus).
/// </summary>
public interface ILeucopeza
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
