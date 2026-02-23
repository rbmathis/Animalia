using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Cryptobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Cryptobranchidae.Cryptobranchus;

/// <summary>
/// Abstract class for Cryptobranchus (genus).
/// NCBI TaxId: 43047
/// </summary>
public abstract class Cryptobranchus : Cryptobranchidae, ICryptobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43047;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptobranchus";

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
