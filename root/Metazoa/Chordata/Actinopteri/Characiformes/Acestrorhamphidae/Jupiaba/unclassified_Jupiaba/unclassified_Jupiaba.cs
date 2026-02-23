using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Jupiaba;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Jupiaba.unclassified_Jupiaba;

/// <summary>
/// Abstract class for unclassified Jupiaba (no rank).
/// NCBI TaxId: 2621053
/// </summary>
public abstract class unclassified_Jupiaba : Jupiaba, Iunclassified_Jupiaba
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Jupiaba";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621053;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Jupiaba";
}
