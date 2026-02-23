using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dinodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dinodon.unclassified_Dinodon;

/// <summary>
/// Abstract class for unclassified Dinodon (no rank).
/// NCBI TaxId: 2646540
/// </summary>
public abstract class unclassified_Dinodon : Dinodon, Iunclassified_Dinodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dinodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646540;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dinodon";
}
