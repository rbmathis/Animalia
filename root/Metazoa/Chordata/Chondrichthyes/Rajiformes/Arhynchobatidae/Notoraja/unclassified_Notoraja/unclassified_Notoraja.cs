using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Notoraja;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Arhynchobatidae.Notoraja.unclassified_Notoraja;

/// <summary>
/// Abstract class for unclassified Notoraja (no rank).
/// NCBI TaxId: 2631611
/// </summary>
public abstract class unclassified_Notoraja : Notoraja, Iunclassified_Notoraja
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Notoraja";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631611;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Notoraja";
}
