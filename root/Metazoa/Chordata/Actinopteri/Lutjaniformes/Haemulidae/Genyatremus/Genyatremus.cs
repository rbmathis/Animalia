using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Genyatremus;

/// <summary>
/// Abstract class for Genyatremus (genus).
/// NCBI TaxId: 531330
/// </summary>
public abstract class Genyatremus : Haemulidae, IGenyatremus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Genyatremus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 531330;

    /// <inheritdoc />
    public virtual string GenusName => "Genyatremus";

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
