using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.unclassified_Sciaenidae;

/// <summary>
/// Abstract class for unclassified Sciaenidae (no rank).
/// NCBI TaxId: 546506
/// </summary>
public abstract class unclassified_Sciaenidae : Sciaenidae, Iunclassified_Sciaenidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Sciaenidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 546506;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Sciaenidae";
}
