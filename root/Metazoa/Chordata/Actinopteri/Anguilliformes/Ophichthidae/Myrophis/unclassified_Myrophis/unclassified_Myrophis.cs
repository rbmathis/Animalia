using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Myrophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Myrophis.unclassified_Myrophis;

/// <summary>
/// Abstract class for unclassified Myrophis (no rank).
/// NCBI TaxId: 2637855
/// </summary>
public abstract class unclassified_Myrophis : Myrophis, Iunclassified_Myrophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myrophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637855;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myrophis";
}
