using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Uperoleia;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Myobatrachidae.Uperoleia.unclassified_Uperoleia;

/// <summary>
/// Abstract class for unclassified Uperoleia (no rank).
/// NCBI TaxId: 2869599
/// </summary>
public abstract class unclassified_Uperoleia : Uperoleia, Iunclassified_Uperoleia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Uperoleia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2869599;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Uperoleia";
}
