namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dicruridae.Machaerirhynchus;

/// <summary>
/// Interface defining characteristics of Machaerirhynchus (genus).
/// </summary>
public interface IMachaerirhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
