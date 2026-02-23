using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Lonchorhina;

/// <summary>
/// Abstract class for Lonchorhina (genus).
/// NCBI TaxId: 148054
/// </summary>
public abstract class Lonchorhina : Phyllostomidae, ILonchorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lonchorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148054;

    /// <inheritdoc />
    public virtual string GenusName => "Lonchorhina";

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
