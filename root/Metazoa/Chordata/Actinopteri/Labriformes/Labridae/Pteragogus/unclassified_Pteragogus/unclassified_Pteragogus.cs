using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pteragogus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pteragogus.unclassified_Pteragogus;

/// <summary>
/// Abstract class for unclassified Pteragogus (no rank).
/// NCBI TaxId: 3051885
/// </summary>
public abstract class unclassified_Pteragogus : Pteragogus, Iunclassified_Pteragogus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pteragogus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3051885;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pteragogus";
}
