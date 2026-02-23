using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Myomyrus;

/// <summary>
/// Abstract class for Myomyrus (genus).
/// NCBI TaxId: 89590
/// </summary>
public abstract class Myomyrus : Mormyridae, IMyomyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myomyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89590;

    /// <inheritdoc />
    public virtual string GenusName => "Myomyrus";

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
