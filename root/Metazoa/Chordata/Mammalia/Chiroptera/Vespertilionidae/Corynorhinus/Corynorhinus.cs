using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Corynorhinus;

/// <summary>
/// Abstract class for Corynorhinus (genus).
/// NCBI TaxId: 233861
/// </summary>
public abstract class Corynorhinus : Vespertilionidae, ICorynorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corynorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 233861;

    /// <inheritdoc />
    public virtual string GenusName => "Corynorhinus";

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
