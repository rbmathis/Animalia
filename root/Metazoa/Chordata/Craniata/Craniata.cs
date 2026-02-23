using AnimalKingdom.root.Metazoa.Chordata;

namespace AnimalKingdom.root.Metazoa.Chordata.Craniata;

/// <summary>
/// Abstract class for Craniata (subphylum).
/// NCBI TaxId: 89593
/// </summary>
public abstract class Craniata : Chordata, ICraniata
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Craniata";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "subphylum";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89593;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Craniata";
}
