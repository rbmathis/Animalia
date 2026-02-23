using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Stellifer;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Stellifer.unclassified_Stellifer;

/// <summary>
/// Abstract class for unclassified Stellifer (no rank).
/// NCBI TaxId: 2649477
/// </summary>
public abstract class unclassified_Stellifer : Stellifer, Iunclassified_Stellifer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Stellifer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649477;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Stellifer";
}
