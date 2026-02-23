using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Pollimyrus;

/// <summary>
/// Abstract class for Pollimyrus (genus).
/// NCBI TaxId: 69935
/// </summary>
public abstract class Pollimyrus : Mormyridae, IPollimyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pollimyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 69935;

    /// <inheritdoc />
    public virtual string GenusName => "Pollimyrus";

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
