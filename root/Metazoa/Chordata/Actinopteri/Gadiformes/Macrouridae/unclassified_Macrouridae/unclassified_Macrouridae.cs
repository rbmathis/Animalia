using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.unclassified_Macrouridae;

/// <summary>
/// Abstract class for unclassified Macrouridae (no rank).
/// NCBI TaxId: 2048809
/// </summary>
public abstract class unclassified_Macrouridae : Macrouridae, Iunclassified_Macrouridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macrouridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2048809;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macrouridae";
}
