using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.unclassified_Characiformes;

/// <summary>
/// Abstract class for unclassified Characiformes (no rank).
/// NCBI TaxId: 723960
/// </summary>
public abstract class unclassified_Characiformes : Characiformes, Iunclassified_Characiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Characiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 723960;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Characiformes";
}
