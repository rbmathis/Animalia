using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Paracontias;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Paracontias.unclassified_Paracontias;

/// <summary>
/// Abstract class for unclassified Paracontias (no rank).
/// NCBI TaxId: 2634031
/// </summary>
public abstract class unclassified_Paracontias : Paracontias, Iunclassified_Paracontias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Paracontias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634031;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Paracontias";
}
