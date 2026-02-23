using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Raja;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Rajidae.Raja.unclassified_Raja;

/// <summary>
/// Abstract class for unclassified Raja (no rank).
/// NCBI TaxId: 2641028
/// </summary>
public abstract class unclassified_Raja : Raja, Iunclassified_Raja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Raja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641028;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Raja";
}
