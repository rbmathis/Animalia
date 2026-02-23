using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae.Pareas;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae.Pareas.unclassified_Pareas;

/// <summary>
/// Abstract class for unclassified Pareas (no rank).
/// NCBI TaxId: 2717037
/// </summary>
public abstract class unclassified_Pareas : Pareas, Iunclassified_Pareas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pareas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2717037;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pareas";
}
