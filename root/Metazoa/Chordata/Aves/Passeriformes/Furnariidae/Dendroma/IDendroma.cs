namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Dendroma;

/// <summary>
/// Interface defining characteristics of Dendroma (genus).
/// </summary>
public interface IDendroma
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
