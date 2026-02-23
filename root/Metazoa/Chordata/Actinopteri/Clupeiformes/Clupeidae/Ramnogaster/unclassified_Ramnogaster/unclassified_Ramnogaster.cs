using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Ramnogaster;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Ramnogaster.unclassified_Ramnogaster;

/// <summary>
/// Abstract class for unclassified Ramnogaster (no rank).
/// NCBI TaxId: 2645118
/// </summary>
public abstract class unclassified_Ramnogaster : Ramnogaster, Iunclassified_Ramnogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ramnogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645118;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ramnogaster";
}
