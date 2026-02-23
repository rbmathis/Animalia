using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Genyomyrus;

/// <summary>
/// Abstract class for Genyomyrus (genus).
/// NCBI TaxId: 89588
/// </summary>
public abstract class Genyomyrus : Mormyridae, IGenyomyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Genyomyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 89588;

    /// <inheritdoc />
    public virtual string GenusName => "Genyomyrus";

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
