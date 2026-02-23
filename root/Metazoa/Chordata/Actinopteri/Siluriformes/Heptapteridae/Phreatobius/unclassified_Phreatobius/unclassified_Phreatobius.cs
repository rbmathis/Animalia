using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Phreatobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Phreatobius.unclassified_Phreatobius;

/// <summary>
/// Abstract class for unclassified Phreatobius (no rank).
/// NCBI TaxId: 2627017
/// </summary>
public abstract class unclassified_Phreatobius : Phreatobius, Iunclassified_Phreatobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phreatobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627017;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phreatobius";
}
