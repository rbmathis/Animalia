using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Coelorinchus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Coelorinchus.unclassified_Coelorinchus;

/// <summary>
/// Abstract class for unclassified Coelorinchus (no rank).
/// NCBI TaxId: 2625321
/// </summary>
public abstract class unclassified_Coelorinchus : Coelorinchus, Iunclassified_Coelorinchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Coelorinchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625321;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Coelorinchus";
}
