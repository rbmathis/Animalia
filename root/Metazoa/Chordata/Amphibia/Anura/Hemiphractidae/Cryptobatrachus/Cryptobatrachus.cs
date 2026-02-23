using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Cryptobatrachus;

/// <summary>
/// Abstract class for Cryptobatrachus (genus).
/// NCBI TaxId: 248783
/// </summary>
public abstract class Cryptobatrachus : Hemiphractidae, ICryptobatrachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptobatrachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 248783;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptobatrachus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
