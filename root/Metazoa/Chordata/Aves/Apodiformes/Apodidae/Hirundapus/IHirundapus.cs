namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Apodidae.Hirundapus;

/// <summary>
/// Interface defining characteristics of Hirundapus (genus).
/// </summary>
public interface IHirundapus
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
