using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sundasalanx;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sundasalanx.unclassified_Sundasalanx;

/// <summary>
/// Abstract class for unclassified Sundasalanx (no rank).
/// NCBI TaxId: 2634960
/// </summary>
public abstract class unclassified_Sundasalanx : Sundasalanx, Iunclassified_Sundasalanx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sundasalanx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634960;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sundasalanx";
}
