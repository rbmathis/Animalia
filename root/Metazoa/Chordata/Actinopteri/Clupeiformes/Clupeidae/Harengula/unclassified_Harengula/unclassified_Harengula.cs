using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Harengula;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Harengula.unclassified_Harengula;

/// <summary>
/// Abstract class for unclassified Harengula (no rank).
/// NCBI TaxId: 2629875
/// </summary>
public abstract class unclassified_Harengula : Harengula, Iunclassified_Harengula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Harengula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629875;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Harengula";
}
