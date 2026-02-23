using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Lycophidion;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Lycophidion.unclassified_Lycophidion;

/// <summary>
/// Abstract class for unclassified Lycophidion (no rank).
/// NCBI TaxId: 2634586
/// </summary>
public abstract class unclassified_Lycophidion : Lycophidion, Iunclassified_Lycophidion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lycophidion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634586;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lycophidion";
}
