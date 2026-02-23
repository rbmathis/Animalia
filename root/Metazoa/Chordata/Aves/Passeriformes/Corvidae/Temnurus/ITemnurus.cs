namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Temnurus;

/// <summary>
/// Interface defining characteristics of Temnurus (genus).
/// </summary>
public interface ITemnurus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
