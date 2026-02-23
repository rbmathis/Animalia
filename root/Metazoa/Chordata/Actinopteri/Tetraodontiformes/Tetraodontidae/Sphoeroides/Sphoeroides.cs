using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Sphoeroides;

/// <summary>
/// Abstract class for Sphoeroides (genus).
/// NCBI TaxId: 39109
/// </summary>
public abstract class Sphoeroides : Tetraodontidae, ISphoeroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphoeroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39109;

    /// <inheritdoc />
    public virtual string GenusName => "Sphoeroides";

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
