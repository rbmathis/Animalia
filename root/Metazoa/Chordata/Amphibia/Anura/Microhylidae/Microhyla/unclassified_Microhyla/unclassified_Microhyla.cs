using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Microhyla.unclassified_Microhyla;

/// <summary>
/// Abstract class for unclassified Microhyla (no rank).
/// NCBI TaxId: 2609362
/// </summary>
public abstract class unclassified_Microhyla : Microhyla, Iunclassified_Microhyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Microhyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609362;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Microhyla";
}
