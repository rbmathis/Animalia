using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Pomadasys;

/// <summary>
/// Abstract class for Pomadasys (genus).
/// NCBI TaxId: 119737
/// </summary>
public abstract class Pomadasys : Haemulidae, IPomadasys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pomadasys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119737;

    /// <inheritdoc />
    public virtual string GenusName => "Pomadasys";

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
