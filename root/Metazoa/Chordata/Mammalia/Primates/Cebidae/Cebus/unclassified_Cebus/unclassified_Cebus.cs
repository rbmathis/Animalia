using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Cebus;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.Cebidae.Cebus.unclassified_Cebus;

/// <summary>
/// Abstract class for unclassified Cebus (no rank).
/// NCBI TaxId: 2618788
/// </summary>
public abstract class unclassified_Cebus : Cebus, Iunclassified_Cebus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cebus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618788;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cebus";
}
