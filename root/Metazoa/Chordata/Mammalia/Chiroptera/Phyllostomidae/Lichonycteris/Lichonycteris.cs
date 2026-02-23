using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Lichonycteris;

/// <summary>
/// Abstract class for Lichonycteris (genus).
/// NCBI TaxId: 148045
/// </summary>
public abstract class Lichonycteris : Phyllostomidae, ILichonycteris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lichonycteris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148045;

    /// <inheritdoc />
    public virtual string GenusName => "Lichonycteris";

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
