using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Cordylus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cordylidae.Cordylus.unclassified_Cordylus;

/// <summary>
/// Abstract class for unclassified Cordylus (no rank).
/// NCBI TaxId: 2621354
/// </summary>
public abstract class unclassified_Cordylus : Cordylus, Iunclassified_Cordylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cordylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621354;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cordylus";
}
