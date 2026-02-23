using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Magadanichthys;

/// <summary>
/// Abstract class for Magadanichthys (genus).
/// NCBI TaxId: 470923
/// </summary>
public abstract class Magadanichthys : Zoarcidae, IMagadanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Magadanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 470923;

    /// <inheritdoc />
    public virtual string GenusName => "Magadanichthys";

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
