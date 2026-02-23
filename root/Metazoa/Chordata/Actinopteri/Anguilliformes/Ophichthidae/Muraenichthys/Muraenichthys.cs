using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Muraenichthys;

/// <summary>
/// Abstract class for Muraenichthys (genus).
/// NCBI TaxId: 190108
/// </summary>
public abstract class Muraenichthys : Ophichthidae, IMuraenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Muraenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190108;

    /// <inheritdoc />
    public virtual string GenusName => "Muraenichthys";

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
