using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Trachonurus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.Trachonurus.unclassified_Trachonurus;

/// <summary>
/// Abstract class for unclassified Trachonurus (no rank).
/// NCBI TaxId: 2620557
/// </summary>
public abstract class unclassified_Trachonurus : Trachonurus, Iunclassified_Trachonurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachonurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2620557;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachonurus";
}
