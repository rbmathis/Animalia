using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Spratelloides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Spratelloides.unclassified_Spratelloides;

/// <summary>
/// Abstract class for unclassified Spratelloides (no rank).
/// NCBI TaxId: 2965644
/// </summary>
public abstract class unclassified_Spratelloides : Spratelloides, Iunclassified_Spratelloides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Spratelloides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2965644;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Spratelloides";
}
