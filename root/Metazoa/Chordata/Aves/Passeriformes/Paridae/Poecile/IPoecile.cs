namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Poecile;

/// <summary>
/// Interface defining characteristics of Poecile (genus).
/// </summary>
public interface IPoecile
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
