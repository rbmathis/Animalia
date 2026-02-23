using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.unclassified_Gobionellinae;

/// <summary>
/// Abstract class for unclassified Gobionellinae (no rank).
/// NCBI TaxId: 1696847
/// </summary>
public abstract class unclassified_Gobionellinae : Gobiidae, Iunclassified_Gobionellinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobionellinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1696847;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobionellinae";
}
