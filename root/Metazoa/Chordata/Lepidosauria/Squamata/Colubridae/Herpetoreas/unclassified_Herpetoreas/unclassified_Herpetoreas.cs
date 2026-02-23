using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Herpetoreas;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Herpetoreas.unclassified_Herpetoreas;

/// <summary>
/// Abstract class for unclassified Herpetoreas (no rank).
/// NCBI TaxId: 2879139
/// </summary>
public abstract class unclassified_Herpetoreas : Herpetoreas, Iunclassified_Herpetoreas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Herpetoreas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2879139;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Herpetoreas";
}
