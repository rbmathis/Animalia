using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Tetraodon;

/// <summary>
/// Abstract class for Tetraodon (genus).
/// NCBI TaxId: 47144
/// </summary>
public abstract class Tetraodon : Tetraodontidae, ITetraodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tetraodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 47144;

    /// <inheritdoc />
    public virtual string GenusName => "Tetraodon";

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
