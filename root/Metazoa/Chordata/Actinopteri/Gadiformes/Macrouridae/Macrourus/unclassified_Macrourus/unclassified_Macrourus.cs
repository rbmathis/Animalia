using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Macrourus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Macrourus.unclassified_Macrourus;

/// <summary>
/// Abstract class for unclassified Macrourus (no rank).
/// NCBI TaxId: 2629664
/// </summary>
public abstract class unclassified_Macrourus : Macrourus, Iunclassified_Macrourus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Macrourus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629664;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Macrourus";
}
