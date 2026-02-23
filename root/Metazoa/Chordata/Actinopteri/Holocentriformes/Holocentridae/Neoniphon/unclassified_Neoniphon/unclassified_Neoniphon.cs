using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Neoniphon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Holocentriformes.Holocentridae.Neoniphon.unclassified_Neoniphon;

/// <summary>
/// Abstract class for unclassified Neoniphon (no rank).
/// NCBI TaxId: 2645698
/// </summary>
public abstract class unclassified_Neoniphon : Neoniphon, Iunclassified_Neoniphon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Neoniphon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2645698;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Neoniphon";
}
