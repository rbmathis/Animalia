using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Brachionichthyidae.Brachionichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Brachionichthyidae.Brachionichthys.unclassified_Brachionichthys;

/// <summary>
/// Abstract class for unclassified Brachionichthys (no rank).
/// NCBI TaxId: 2923201
/// </summary>
public abstract class unclassified_Brachionichthys : Brachionichthys, Iunclassified_Brachionichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachionichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2923201;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachionichthys";
}
