using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.unclassified_Holocentrinae;

/// <summary>
/// Abstract class for unclassified Holocentrinae (no rank).
/// NCBI TaxId: 1519065
/// </summary>
public abstract class unclassified_Holocentrinae : Holocentridae, Iunclassified_Holocentrinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Holocentrinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1519065;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Holocentrinae";
}
