using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Insentiraja;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Insentiraja.unclassified_Insentiraja;

/// <summary>
/// Abstract class for unclassified Insentiraja (no rank).
/// NCBI TaxId: 2626190
/// </summary>
public abstract class unclassified_Insentiraja : Insentiraja, Iunclassified_Insentiraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Insentiraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626190;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Insentiraja";
}
