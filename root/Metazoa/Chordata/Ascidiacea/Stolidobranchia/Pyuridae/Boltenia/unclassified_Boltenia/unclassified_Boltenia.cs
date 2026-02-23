using AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Boltenia;

namespace AnimalKingdom.root.Metazoa.Chordata.Ascidiacea.Stolidobranchia.Pyuridae.Boltenia.unclassified_Boltenia;

/// <summary>
/// Abstract class for unclassified Boltenia (no rank).
/// NCBI TaxId: 2630480
/// </summary>
public abstract class unclassified_Boltenia : Boltenia, Iunclassified_Boltenia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Boltenia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630480;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Boltenia";
}
