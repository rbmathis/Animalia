using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Synbranchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Synbranchiformes.Synbranchidae.Synbranchus.unclassified_Synbranchus;

/// <summary>
/// Abstract class for unclassified Synbranchus (no rank).
/// NCBI TaxId: 2812828
/// </summary>
public abstract class unclassified_Synbranchus : Synbranchus, Iunclassified_Synbranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Synbranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2812828;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Synbranchus";
}
