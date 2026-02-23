using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Cryptophis;

/// <summary>
/// Abstract class for Cryptophis (genus).
/// NCBI TaxId: 1194343
/// </summary>
public abstract class Cryptophis : Elapidae, ICryptophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1194343;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptophis";

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
