using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Carinotetraodon;

/// <summary>
/// Abstract class for Carinotetraodon (genus).
/// NCBI TaxId: 500394
/// </summary>
public abstract class Carinotetraodon : Tetraodontidae, ICarinotetraodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carinotetraodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 500394;

    /// <inheritdoc />
    public virtual string GenusName => "Carinotetraodon";

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
