using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Nibea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.Nibea.unclassified_Nibea;

/// <summary>
/// Abstract class for unclassified Nibea (no rank).
/// NCBI TaxId: 2634710
/// </summary>
public abstract class unclassified_Nibea : Nibea, Iunclassified_Nibea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nibea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634710;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nibea";
}
