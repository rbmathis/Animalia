using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Triportheidae.Triportheus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Triportheidae.Triportheus.unclassified_Triportheus;

/// <summary>
/// Abstract class for unclassified Triportheus (no rank).
/// NCBI TaxId: 2641900
/// </summary>
public abstract class unclassified_Triportheus : Triportheus, Iunclassified_Triportheus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Triportheus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2641900;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Triportheus";
}
