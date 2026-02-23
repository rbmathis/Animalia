using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillaginodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.Sillaginodes.unclassified_Sillaginodes;

/// <summary>
/// Abstract class for unclassified Sillaginodes (no rank).
/// NCBI TaxId: 2755198
/// </summary>
public abstract class unclassified_Sillaginodes : Sillaginodes, Iunclassified_Sillaginodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sillaginodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2755198;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sillaginodes";
}
