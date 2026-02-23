using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Konosirus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Konosirus.unclassified_Konosirus;

/// <summary>
/// Abstract class for unclassified Konosirus (no rank).
/// NCBI TaxId: 3133202
/// </summary>
public abstract class unclassified_Konosirus : Konosirus, Iunclassified_Konosirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Konosirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3133202;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Konosirus";
}
