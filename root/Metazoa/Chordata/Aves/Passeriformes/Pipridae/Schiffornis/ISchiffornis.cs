namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pipridae.Schiffornis;

/// <summary>
/// Interface defining characteristics of Schiffornis (genus).
/// </summary>
public interface ISchiffornis
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
