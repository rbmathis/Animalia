using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Turdinus;

/// <summary>
/// Abstract class for Turdinus (genus).
/// NCBI TaxId: 1743390
/// </summary>
public abstract class Turdinus : Pellorneidae, ITurdinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Turdinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1743390;

    /// <inheritdoc />
    public virtual string GenusName => "Turdinus";

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
