using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Marcusenius;

/// <summary>
/// Abstract class for Marcusenius (genus).
/// NCBI TaxId: 42649
/// </summary>
public abstract class Marcusenius : Mormyridae, IMarcusenius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marcusenius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42649;

    /// <inheritdoc />
    public virtual string GenusName => "Marcusenius";

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
