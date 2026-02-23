using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.unclassified_Chondrichthyes;

/// <summary>
/// Abstract class for unclassified Chondrichthyes (no rank).
/// NCBI TaxId: 1197973
/// </summary>
public abstract class unclassified_Chondrichthyes : Chondrichthyes, Iunclassified_Chondrichthyes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Chondrichthyes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1197973;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Chondrichthyes";
}
