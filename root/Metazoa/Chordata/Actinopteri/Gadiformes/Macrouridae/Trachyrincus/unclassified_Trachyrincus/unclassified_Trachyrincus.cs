using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Trachyrincus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Trachyrincus.unclassified_Trachyrincus;

/// <summary>
/// Abstract class for unclassified Trachyrincus (no rank).
/// NCBI TaxId: 2621473
/// </summary>
public abstract class unclassified_Trachyrincus : Trachyrincus, Iunclassified_Trachyrincus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachyrincus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621473;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachyrincus";
}
