using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hylophorbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Hylophorbus.unclassified_Hylophorbus;

/// <summary>
/// Abstract class for unclassified Hylophorbus (no rank).
/// NCBI TaxId: 2619325
/// </summary>
public abstract class unclassified_Hylophorbus : Hylophorbus, Iunclassified_Hylophorbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hylophorbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619325;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hylophorbus";
}
