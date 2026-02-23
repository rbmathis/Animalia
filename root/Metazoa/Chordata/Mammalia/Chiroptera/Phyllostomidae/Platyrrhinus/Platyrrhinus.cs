using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Platyrrhinus;

/// <summary>
/// Abstract class for Platyrrhinus (genus).
/// NCBI TaxId: 27657
/// </summary>
public abstract class Platyrrhinus : Phyllostomidae, IPlatyrrhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platyrrhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27657;

    /// <inheritdoc />
    public virtual string GenusName => "Platyrrhinus";

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
