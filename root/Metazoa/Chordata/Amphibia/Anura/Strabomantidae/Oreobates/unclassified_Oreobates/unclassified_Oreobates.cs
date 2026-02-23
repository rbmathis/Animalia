using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Oreobates;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Strabomantidae.Oreobates.unclassified_Oreobates;

/// <summary>
/// Abstract class for unclassified Oreobates (no rank).
/// NCBI TaxId: 2774134
/// </summary>
public abstract class unclassified_Oreobates : Oreobates, Iunclassified_Oreobates
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oreobates";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2774134;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oreobates";
}
