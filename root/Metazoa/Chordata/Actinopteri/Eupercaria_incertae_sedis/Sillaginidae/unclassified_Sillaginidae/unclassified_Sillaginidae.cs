using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sillaginidae.unclassified_Sillaginidae;

/// <summary>
/// Abstract class for unclassified Sillaginidae (no rank).
/// NCBI TaxId: 2613826
/// </summary>
public abstract class unclassified_Sillaginidae : Sillaginidae, Iunclassified_Sillaginidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sillaginidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613826;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sillaginidae";
}
