using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Marilyna;

/// <summary>
/// Abstract class for Marilyna (genus).
/// NCBI TaxId: 303750
/// </summary>
public abstract class Marilyna : Tetraodontidae, IMarilyna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Marilyna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303750;

    /// <inheritdoc />
    public virtual string GenusName => "Marilyna";

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
