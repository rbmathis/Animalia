namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Cracidae.Crax;

/// <summary>
/// Interface defining characteristics of Crax (genus).
/// </summary>
public interface ICrax
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
