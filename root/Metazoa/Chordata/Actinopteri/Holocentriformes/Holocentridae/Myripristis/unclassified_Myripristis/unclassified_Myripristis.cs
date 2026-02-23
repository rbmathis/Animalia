using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Myripristis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Myripristis.unclassified_Myripristis;

/// <summary>
/// Abstract class for unclassified Myripristis (no rank).
/// NCBI TaxId: 2631899
/// </summary>
public abstract class unclassified_Myripristis : Myripristis, Iunclassified_Myripristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Myripristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631899;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Myripristis";
}
