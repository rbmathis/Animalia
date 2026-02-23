using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Cephaloscyllium;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Cephaloscyllium.unclassified_Cephaloscyllium;

/// <summary>
/// Abstract class for unclassified Cephaloscyllium (no rank).
/// NCBI TaxId: 2625928
/// </summary>
public abstract class unclassified_Cephaloscyllium : Cephaloscyllium, Iunclassified_Cephaloscyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cephaloscyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625928;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cephaloscyllium";
}
