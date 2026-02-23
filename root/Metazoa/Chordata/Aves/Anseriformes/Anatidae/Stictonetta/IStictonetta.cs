namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Stictonetta;

/// <summary>
/// Interface defining characteristics of Stictonetta (genus).
/// </summary>
public interface IStictonetta
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
