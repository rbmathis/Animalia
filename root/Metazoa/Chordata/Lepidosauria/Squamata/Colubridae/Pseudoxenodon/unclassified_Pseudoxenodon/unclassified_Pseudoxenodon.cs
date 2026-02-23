using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pseudoxenodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pseudoxenodon.unclassified_Pseudoxenodon;

/// <summary>
/// Abstract class for unclassified Pseudoxenodon (no rank).
/// NCBI TaxId: 2630362
/// </summary>
public abstract class unclassified_Pseudoxenodon : Pseudoxenodon, Iunclassified_Pseudoxenodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudoxenodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630362;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudoxenodon";
}
