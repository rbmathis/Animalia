using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tachymenis;

/// <summary>
/// Abstract class for Tachymenis (genus).
/// NCBI TaxId: 666119
/// </summary>
public abstract class Tachymenis : Dipsadidae, ITachymenis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tachymenis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666119;

    /// <inheritdoc />
    public virtual string GenusName => "Tachymenis";

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
