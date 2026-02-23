using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Acrochordidae.Plagiopholis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Acrochordidae.Plagiopholis.unclassified_Plagiopholis;

/// <summary>
/// Abstract class for unclassified Plagiopholis (no rank).
/// NCBI TaxId: 3410094
/// </summary>
public abstract class unclassified_Plagiopholis : Plagiopholis, Iunclassified_Plagiopholis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Plagiopholis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3410094;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Plagiopholis";
}
