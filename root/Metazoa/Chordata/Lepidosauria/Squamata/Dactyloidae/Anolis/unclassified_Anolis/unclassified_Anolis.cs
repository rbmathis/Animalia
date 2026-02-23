using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dactyloidae.Anolis.unclassified_Anolis;

/// <summary>
/// Abstract class for unclassified Anolis (no rank).
/// NCBI TaxId: 2163907
/// </summary>
public abstract class unclassified_Anolis : Anolis, Iunclassified_Anolis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Anolis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2163907;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Anolis";
}
