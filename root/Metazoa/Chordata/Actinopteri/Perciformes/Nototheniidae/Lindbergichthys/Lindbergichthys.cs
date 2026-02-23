using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Lindbergichthys;

/// <summary>
/// Abstract class for Lindbergichthys (genus).
/// NCBI TaxId: 2816473
/// </summary>
public abstract class Lindbergichthys : Nototheniidae, ILindbergichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lindbergichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2816473;

    /// <inheritdoc />
    public virtual string GenusName => "Lindbergichthys";

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
