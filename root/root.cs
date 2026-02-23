namespace AnimalKingdom.root;

/// <summary>
/// Abstract class for root (no rank).
/// NCBI TaxId: 1
/// </summary>
public abstract class root : Iroot
{
    /// <summary>Gets the scientific name.</summary>
    public virtual string ScientificName => "root";

    /// <summary>Gets the taxonomic rank.</summary>
    public virtual string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public virtual int TaxId => 1;

    /// <inheritdoc />
    public virtual string Description => "Taxon: root";
}
