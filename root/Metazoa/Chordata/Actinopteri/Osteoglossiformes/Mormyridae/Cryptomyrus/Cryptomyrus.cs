using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Cryptomyrus;

/// <summary>
/// Abstract class for Cryptomyrus (genus).
/// NCBI TaxId: 1736031
/// </summary>
public abstract class Cryptomyrus : Mormyridae, ICryptomyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptomyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1736031;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptomyrus";

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
