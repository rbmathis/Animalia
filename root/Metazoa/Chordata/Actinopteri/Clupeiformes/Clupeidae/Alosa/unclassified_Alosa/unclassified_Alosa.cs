using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Alosa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Alosa.unclassified_Alosa;

/// <summary>
/// Abstract class for unclassified Alosa (no rank).
/// NCBI TaxId: 2634140
/// </summary>
public abstract class unclassified_Alosa : Alosa, Iunclassified_Alosa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Alosa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634140;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Alosa";
}
