namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Seiurus;

/// <summary>
/// Interface defining characteristics of Seiurus (genus).
/// </summary>
public interface ISeiurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
