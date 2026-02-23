using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Osteoglossiformes.Mormyridae.Heteromormyrus;

/// <summary>
/// Abstract class for Heteromormyrus (genus).
/// NCBI TaxId: 2650613
/// </summary>
public abstract class Heteromormyrus : Mormyridae, IHeteromormyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteromormyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2650613;

    /// <inheritdoc />
    public virtual string GenusName => "Heteromormyrus";

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
