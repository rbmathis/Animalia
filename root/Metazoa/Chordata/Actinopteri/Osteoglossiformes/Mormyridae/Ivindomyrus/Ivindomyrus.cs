using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Ivindomyrus;

/// <summary>
/// Abstract class for Ivindomyrus (genus).
/// NCBI TaxId: 91726
/// </summary>
public abstract class Ivindomyrus : Mormyridae, IIvindomyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ivindomyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91726;

    /// <inheritdoc />
    public virtual string GenusName => "Ivindomyrus";

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
