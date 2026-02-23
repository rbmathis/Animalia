using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Pedioplanis;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Pedioplanis.unclassified_Pedioplanis;

/// <summary>
/// Abstract class for unclassified Pedioplanis (no rank).
/// NCBI TaxId: 2642199
/// </summary>
public abstract class unclassified_Pedioplanis : Pedioplanis, Iunclassified_Pedioplanis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pedioplanis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2642199;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pedioplanis";
}
