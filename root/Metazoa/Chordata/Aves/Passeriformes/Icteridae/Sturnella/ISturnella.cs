namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Sturnella;

/// <summary>
/// Interface defining characteristics of Sturnella (genus).
/// </summary>
public interface ISturnella
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
