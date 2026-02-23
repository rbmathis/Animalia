using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Amphiglossus;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Amphiglossus.unclassified_Amphiglossus;

/// <summary>
/// Abstract class for unclassified Amphiglossus (no rank).
/// NCBI TaxId: 2644861
/// </summary>
public abstract class unclassified_Amphiglossus : Amphiglossus, Iunclassified_Amphiglossus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Amphiglossus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644861;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Amphiglossus";
}
