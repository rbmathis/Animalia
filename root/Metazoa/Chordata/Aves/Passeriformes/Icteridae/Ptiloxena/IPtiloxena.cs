namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Ptiloxena;

/// <summary>
/// Interface defining characteristics of Ptiloxena (genus).
/// </summary>
public interface IPtiloxena
{
    /// <inheritdoc />
    string GenusName { get; }

    /// <inheritdoc />
    string[] GenusCharacteristics { get; }

    /// <inheritdoc />
    bool CanInterbreed { get; }

}
