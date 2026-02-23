namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Batara;

/// <summary>
/// Interface defining characteristics of Batara (genus).
/// </summary>
public interface IBatara
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
