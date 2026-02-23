namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Mniotilta;

/// <summary>
/// Interface defining characteristics of Mniotilta (genus).
/// </summary>
public interface IMniotilta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
