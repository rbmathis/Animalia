using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiosoma;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Gobiosoma.unclassified_Gobiosoma;

/// <summary>
/// Abstract class for unclassified Gobiosoma (no rank).
/// NCBI TaxId: 2627350
/// </summary>
public abstract class unclassified_Gobiosoma : Gobiosoma, Iunclassified_Gobiosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627350;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiosoma";
}
