using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Blenniidae.Istiblennius;

/// <summary>
/// Abstract class for Istiblennius (genus).
/// NCBI TaxId: 587054
/// </summary>
public abstract class Istiblennius : Blenniidae, IIstiblennius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Istiblennius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 587054;

    /// <inheritdoc />
    public virtual string GenusName => "Istiblennius";

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
