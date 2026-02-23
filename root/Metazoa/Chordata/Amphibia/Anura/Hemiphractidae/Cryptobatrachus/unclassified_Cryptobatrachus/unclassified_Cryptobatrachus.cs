using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Cryptobatrachus;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Cryptobatrachus.unclassified_Cryptobatrachus;

/// <summary>
/// Abstract class for unclassified Cryptobatrachus (no rank).
/// NCBI TaxId: 2629518
/// </summary>
public abstract class unclassified_Cryptobatrachus : Cryptobatrachus, Iunclassified_Cryptobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cryptobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629518;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cryptobatrachus";
}
