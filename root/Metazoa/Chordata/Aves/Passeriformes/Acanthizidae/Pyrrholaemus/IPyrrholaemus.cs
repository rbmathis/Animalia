namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthizidae.Pyrrholaemus;

/// <summary>
/// Interface defining characteristics of Pyrrholaemus (genus).
/// </summary>
public interface IPyrrholaemus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
