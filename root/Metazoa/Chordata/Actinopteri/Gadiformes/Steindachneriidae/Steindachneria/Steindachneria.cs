using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Steindachneriidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Steindachneriidae.Steindachneria;

/// <summary>
/// Abstract class for Steindachneria (genus).
/// NCBI TaxId: 500386
/// </summary>
public abstract class Steindachneria : Steindachneriidae, ISteindachneria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Steindachneria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 500386;

    /// <inheritdoc />
    public virtual string GenusName => "Steindachneria";

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
