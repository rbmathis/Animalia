using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Hippopotamyrus;

/// <summary>
/// Abstract class for Hippopotamyrus (genus).
/// NCBI TaxId: 91722
/// </summary>
public abstract class Hippopotamyrus : Mormyridae, IHippopotamyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hippopotamyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91722;

    /// <inheritdoc />
    public virtual string GenusName => "Hippopotamyrus";

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
