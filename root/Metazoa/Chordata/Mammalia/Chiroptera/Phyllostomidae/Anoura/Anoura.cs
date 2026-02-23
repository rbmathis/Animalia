using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Anoura;

/// <summary>
/// Abstract class for Anoura (genus).
/// NCBI TaxId: 27641
/// </summary>
public abstract class Anoura : Phyllostomidae, IAnoura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anoura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27641;

    /// <inheritdoc />
    public virtual string GenusName => "Anoura";

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
