using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Cryptobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Cryptobranchidae.Andrias;

/// <summary>
/// Abstract class for Andrias (genus).
/// NCBI TaxId: 141261
/// </summary>
public abstract class Andrias : Cryptobranchidae, IAndrias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andrias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 141261;

    /// <inheritdoc />
    public virtual string GenusName => "Andrias";

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
