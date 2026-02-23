namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Tumbezia;

/// <summary>
/// Interface defining characteristics of Tumbezia (genus).
/// </summary>
public interface ITumbezia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
