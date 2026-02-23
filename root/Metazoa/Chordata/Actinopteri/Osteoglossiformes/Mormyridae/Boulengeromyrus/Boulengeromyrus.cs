using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Boulengeromyrus;

/// <summary>
/// Abstract class for Boulengeromyrus (genus).
/// NCBI TaxId: 91716
/// </summary>
public abstract class Boulengeromyrus : Mormyridae, IBoulengeromyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boulengeromyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 91716;

    /// <inheritdoc />
    public virtual string GenusName => "Boulengeromyrus";

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
