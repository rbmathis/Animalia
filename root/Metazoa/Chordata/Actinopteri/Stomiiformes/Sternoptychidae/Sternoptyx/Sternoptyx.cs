using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Sternoptychidae.Sternoptyx;

/// <summary>
/// Abstract class for Sternoptyx (genus).
/// NCBI TaxId: 81872
/// </summary>
public abstract class Sternoptyx : Sternoptychidae, ISternoptyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sternoptyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 81872;

    /// <inheritdoc />
    public virtual string GenusName => "Sternoptyx";

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
