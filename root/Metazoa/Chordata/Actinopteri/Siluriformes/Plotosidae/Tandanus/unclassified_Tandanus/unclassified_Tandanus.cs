using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Tandanus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Plotosidae.Tandanus.unclassified_Tandanus;

/// <summary>
/// Abstract class for unclassified Tandanus (no rank).
/// NCBI TaxId: 2637089
/// </summary>
public abstract class unclassified_Tandanus : Tandanus, Iunclassified_Tandanus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tandanus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2637089;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tandanus";
}
