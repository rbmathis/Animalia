namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Maluridae.Sipodotus;

/// <summary>
/// Interface defining characteristics of Sipodotus (genus).
/// </summary>
public interface ISipodotus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
