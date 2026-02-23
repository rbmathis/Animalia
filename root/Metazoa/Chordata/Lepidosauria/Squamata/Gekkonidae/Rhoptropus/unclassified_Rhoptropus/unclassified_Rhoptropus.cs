using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Rhoptropus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Rhoptropus.unclassified_Rhoptropus;

/// <summary>
/// Abstract class for unclassified Rhoptropus (no rank).
/// NCBI TaxId: 2926944
/// </summary>
public abstract class unclassified_Rhoptropus : Rhoptropus, Iunclassified_Rhoptropus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhoptropus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2926944;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhoptropus";
}
