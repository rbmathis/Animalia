using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Philypnodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Eleotridae.Philypnodon.unclassified_Philypnodon;

/// <summary>
/// Abstract class for unclassified Philypnodon (no rank).
/// NCBI TaxId: 2645147
/// </summary>
public abstract class unclassified_Philypnodon : Philypnodon, Iunclassified_Philypnodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Philypnodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645147;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Philypnodon";
}
