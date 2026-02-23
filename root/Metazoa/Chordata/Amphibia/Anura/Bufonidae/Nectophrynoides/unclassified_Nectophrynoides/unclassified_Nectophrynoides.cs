using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nectophrynoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Nectophrynoides.unclassified_Nectophrynoides;

/// <summary>
/// Abstract class for unclassified Nectophrynoides (no rank).
/// NCBI TaxId: 2624774
/// </summary>
public abstract class unclassified_Nectophrynoides : Nectophrynoides, Iunclassified_Nectophrynoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nectophrynoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624774;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nectophrynoides";
}
