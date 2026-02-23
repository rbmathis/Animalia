using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Menticirrhus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Menticirrhus.unclassified_Menticirrhus;

/// <summary>
/// Abstract class for unclassified Menticirrhus (no rank).
/// NCBI TaxId: 2629428
/// </summary>
public abstract class unclassified_Menticirrhus : Menticirrhus, Iunclassified_Menticirrhus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Menticirrhus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629428;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Menticirrhus";
}
