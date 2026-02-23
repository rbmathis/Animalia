using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Hyperopisus;

/// <summary>
/// Abstract class for Hyperopisus (genus).
/// NCBI TaxId: 91724
/// </summary>
public abstract class Hyperopisus : Mormyridae, IHyperopisus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyperopisus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91724;

    /// <inheritdoc />
    public virtual string GenusName => "Hyperopisus";

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
