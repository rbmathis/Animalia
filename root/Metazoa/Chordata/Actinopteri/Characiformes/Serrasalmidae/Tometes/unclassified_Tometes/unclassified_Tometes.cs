using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Tometes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Serrasalmidae.Tometes.unclassified_Tometes;

/// <summary>
/// Abstract class for unclassified Tometes (no rank).
/// NCBI TaxId: 2628107
/// </summary>
public abstract class unclassified_Tometes : Tometes, Iunclassified_Tometes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Tometes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2628107;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Tometes";
}
