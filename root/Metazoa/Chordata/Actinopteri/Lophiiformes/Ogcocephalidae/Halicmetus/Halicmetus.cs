using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ogcocephalidae.Halicmetus;

/// <summary>
/// Abstract class for Halicmetus (genus).
/// NCBI TaxId: 1592452
/// </summary>
public abstract class Halicmetus : Ogcocephalidae, IHalicmetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halicmetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1592452;

    /// <inheritdoc />
    public virtual string GenusName => "Halicmetus";

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
