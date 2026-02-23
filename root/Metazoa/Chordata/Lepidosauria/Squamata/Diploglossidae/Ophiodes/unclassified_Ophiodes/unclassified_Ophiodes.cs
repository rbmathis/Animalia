using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Ophiodes;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diploglossidae.Ophiodes.unclassified_Ophiodes;

/// <summary>
/// Abstract class for unclassified Ophiodes (no rank).
/// NCBI TaxId: 2622392
/// </summary>
public abstract class unclassified_Ophiodes : Ophiodes, Iunclassified_Ophiodes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ophiodes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622392;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ophiodes";
}
