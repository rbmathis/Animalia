using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Telmatobius;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ceratophryidae.Telmatobius.unclassified_Telmatobius;

/// <summary>
/// Abstract class for unclassified Telmatobius (no rank).
/// NCBI TaxId: 2633691
/// </summary>
public abstract class unclassified_Telmatobius : Telmatobius, Iunclassified_Telmatobius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Telmatobius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633691;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Telmatobius";
}
