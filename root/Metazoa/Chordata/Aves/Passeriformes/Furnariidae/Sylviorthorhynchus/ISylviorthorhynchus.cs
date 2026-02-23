namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Sylviorthorhynchus;

/// <summary>
/// Interface defining characteristics of Sylviorthorhynchus (genus).
/// </summary>
public interface ISylviorthorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
