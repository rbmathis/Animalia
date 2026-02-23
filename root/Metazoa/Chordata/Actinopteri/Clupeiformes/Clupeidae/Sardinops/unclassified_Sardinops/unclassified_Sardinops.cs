using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinops;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinops.unclassified_Sardinops;

/// <summary>
/// Abstract class for unclassified Sardinops (no rank).
/// NCBI TaxId: 2626595
/// </summary>
public abstract class unclassified_Sardinops : Sardinops, Iunclassified_Sardinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sardinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626595;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sardinops";
}
