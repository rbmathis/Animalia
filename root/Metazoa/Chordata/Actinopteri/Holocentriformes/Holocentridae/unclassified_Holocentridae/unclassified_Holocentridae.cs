using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.unclassified_Holocentridae;

/// <summary>
/// Abstract class for unclassified Holocentridae (no rank).
/// NCBI TaxId: 1182082
/// </summary>
public abstract class unclassified_Holocentridae : Holocentridae, Iunclassified_Holocentridae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Holocentridae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1182082;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Holocentridae";
}
