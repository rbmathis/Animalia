using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Xenichthys;

/// <summary>
/// Abstract class for Xenichthys (genus).
/// NCBI TaxId: 1010793
/// </summary>
public abstract class Xenichthys : Haemulidae, IXenichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1010793;

    /// <inheritdoc />
    public virtual string GenusName => "Xenichthys";

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
