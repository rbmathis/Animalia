using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Conocara;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Conocara.unclassified_Conocara;

/// <summary>
/// Abstract class for unclassified Conocara (no rank).
/// NCBI TaxId: 2638550
/// </summary>
public abstract class unclassified_Conocara : Conocara, Iunclassified_Conocara
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Conocara";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638550;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Conocara";
}
