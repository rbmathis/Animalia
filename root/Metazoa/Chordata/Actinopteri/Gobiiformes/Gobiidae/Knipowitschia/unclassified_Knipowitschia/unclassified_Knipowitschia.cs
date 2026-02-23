using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Knipowitschia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Knipowitschia.unclassified_Knipowitschia;

/// <summary>
/// Abstract class for unclassified Knipowitschia (no rank).
/// NCBI TaxId: 2639462
/// </summary>
public abstract class unclassified_Knipowitschia : Knipowitschia, Iunclassified_Knipowitschia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Knipowitschia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639462;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Knipowitschia";
}
