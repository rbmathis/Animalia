using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Xenocyprididae.Hypophthalmichthys;

/// <summary>
/// Abstract class for Hypophthalmichthys (genus).
/// NCBI TaxId: 7963
/// </summary>
public abstract class Hypophthalmichthys : Xenocyprididae, IHypophthalmichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypophthalmichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7963;

    /// <inheritdoc />
    public virtual string GenusName => "Hypophthalmichthys";

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
