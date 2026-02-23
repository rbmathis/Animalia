using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Mochokidae.Mochokus;

/// <summary>
/// Abstract class for Mochokus (genus).
/// NCBI TaxId: 1273075
/// </summary>
public abstract class Mochokus : Mochokidae, IMochokus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mochokus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1273075;

    /// <inheritdoc />
    public virtual string GenusName => "Mochokus";

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
