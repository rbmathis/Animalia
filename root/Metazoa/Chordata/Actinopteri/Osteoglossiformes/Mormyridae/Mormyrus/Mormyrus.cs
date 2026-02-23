using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Mormyrus;

/// <summary>
/// Abstract class for Mormyrus (genus).
/// NCBI TaxId: 91730
/// </summary>
public abstract class Mormyrus : Mormyridae, IMormyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mormyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91730;

    /// <inheritdoc />
    public virtual string GenusName => "Mormyrus";

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
