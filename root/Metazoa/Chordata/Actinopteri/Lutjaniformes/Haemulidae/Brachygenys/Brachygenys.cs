using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Haemulidae.Brachygenys;

/// <summary>
/// Abstract class for Brachygenys (genus).
/// NCBI TaxId: 2070541
/// </summary>
public abstract class Brachygenys : Haemulidae, IBrachygenys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachygenys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2070541;

    /// <inheritdoc />
    public virtual string GenusName => "Brachygenys";

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
