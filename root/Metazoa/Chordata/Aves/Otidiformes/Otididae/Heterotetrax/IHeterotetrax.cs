namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Heterotetrax;

/// <summary>
/// Interface defining characteristics of Heterotetrax (genus).
/// </summary>
public interface IHeterotetrax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
