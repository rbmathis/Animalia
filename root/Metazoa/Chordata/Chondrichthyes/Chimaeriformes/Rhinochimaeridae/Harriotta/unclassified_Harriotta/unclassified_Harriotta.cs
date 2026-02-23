using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Rhinochimaeridae.Harriotta;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Rhinochimaeridae.Harriotta.unclassified_Harriotta;

/// <summary>
/// Abstract class for unclassified Harriotta (no rank).
/// NCBI TaxId: 3066440
/// </summary>
public abstract class unclassified_Harriotta : Harriotta, Iunclassified_Harriotta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Harriotta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3066440;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Harriotta";
}
