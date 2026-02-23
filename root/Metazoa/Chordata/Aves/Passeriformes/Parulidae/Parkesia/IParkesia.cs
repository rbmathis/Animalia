namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Parkesia;

/// <summary>
/// Interface defining characteristics of Parkesia (genus).
/// </summary>
public interface IParkesia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
