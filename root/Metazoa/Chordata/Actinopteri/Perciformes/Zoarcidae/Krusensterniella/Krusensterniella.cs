using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Krusensterniella;

/// <summary>
/// Abstract class for Krusensterniella (genus).
/// NCBI TaxId: 1354031
/// </summary>
public abstract class Krusensterniella : Zoarcidae, IKrusensterniella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Krusensterniella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1354031;

    /// <inheritdoc />
    public virtual string GenusName => "Krusensterniella";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
