using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Thamnosophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Thamnosophis.unclassified_Thamnosophis;

/// <summary>
/// Abstract class for unclassified Thamnosophis (no rank).
/// NCBI TaxId: 2837593
/// </summary>
public abstract class unclassified_Thamnosophis : Thamnosophis, Iunclassified_Thamnosophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thamnosophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2837593;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thamnosophis";
}
