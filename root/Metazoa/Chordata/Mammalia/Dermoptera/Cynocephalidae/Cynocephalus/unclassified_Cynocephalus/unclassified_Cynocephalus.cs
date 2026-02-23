using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dermoptera.Cynocephalidae.Cynocephalus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dermoptera.Cynocephalidae.Cynocephalus.unclassified_Cynocephalus;

/// <summary>
/// Abstract class for unclassified Cynocephalus (no rank).
/// NCBI TaxId: 2625950
/// </summary>
public abstract class unclassified_Cynocephalus : Cynocephalus, Iunclassified_Cynocephalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cynocephalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625950;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cynocephalus";
}
