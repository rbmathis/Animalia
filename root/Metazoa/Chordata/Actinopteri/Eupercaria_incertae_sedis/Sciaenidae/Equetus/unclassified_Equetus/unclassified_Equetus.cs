using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Equetus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Equetus.unclassified_Equetus;

/// <summary>
/// Abstract class for unclassified Equetus (no rank).
/// NCBI TaxId: 2632146
/// </summary>
public abstract class unclassified_Equetus : Equetus, Iunclassified_Equetus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Equetus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2632146;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Equetus";
}
