using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Stomatorhinus;

/// <summary>
/// Abstract class for Stomatorhinus (genus).
/// NCBI TaxId: 112159
/// </summary>
public abstract class Stomatorhinus : Mormyridae, IStomatorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stomatorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 112159;

    /// <inheritdoc />
    public virtual string GenusName => "Stomatorhinus";

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
