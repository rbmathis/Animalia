namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Camptorhynchus;

/// <summary>
/// Interface defining characteristics of Camptorhynchus (genus).
/// </summary>
public interface ICamptorhynchus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
