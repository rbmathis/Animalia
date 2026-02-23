namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Sialia;

/// <summary>
/// Interface defining characteristics of Sialia (genus).
/// </summary>
public interface ISialia
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
