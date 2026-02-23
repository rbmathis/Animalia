using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Axelrodia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Axelrodia.unclassified_Axelrodia;

/// <summary>
/// Abstract class for unclassified Axelrodia (no rank).
/// NCBI TaxId: 2625819
/// </summary>
public abstract class unclassified_Axelrodia : Axelrodia, Iunclassified_Axelrodia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Axelrodia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2625819;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Axelrodia";
}
