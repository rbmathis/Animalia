namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Corvidae.Cyanocorax;

/// <summary>
/// Interface defining characteristics of Cyanocorax (genus).
/// </summary>
public interface ICyanocorax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
