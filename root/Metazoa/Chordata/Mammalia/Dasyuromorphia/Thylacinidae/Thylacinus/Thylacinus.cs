using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Thylacinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Thylacinidae.Thylacinus;

/// <summary>
/// Abstract class for Thylacinus (genus).
/// NCBI TaxId: 9274
/// </summary>
public abstract class Thylacinus : Thylacinidae, IThylacinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thylacinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9274;

    /// <inheritdoc />
    public virtual string GenusName => "Thylacinus";

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
