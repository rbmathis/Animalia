using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Cyphomyrus;

/// <summary>
/// Abstract class for Cyphomyrus (genus).
/// NCBI TaxId: 1194724
/// </summary>
public abstract class Cyphomyrus : Mormyridae, ICyphomyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyphomyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1194724;

    /// <inheritdoc />
    public virtual string GenusName => "Cyphomyrus";

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
