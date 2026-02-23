using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Notosudidae.Scopelosaurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Aulopiformes.Notosudidae.Scopelosaurus.unclassified_Scopelosaurus;

/// <summary>
/// Abstract class for unclassified Scopelosaurus (no rank).
/// NCBI TaxId: 2630973
/// </summary>
public abstract class unclassified_Scopelosaurus : Scopelosaurus, Iunclassified_Scopelosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Scopelosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630973;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Scopelosaurus";
}
