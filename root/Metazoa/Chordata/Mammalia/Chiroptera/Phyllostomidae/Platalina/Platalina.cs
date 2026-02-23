using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Platalina;

/// <summary>
/// Abstract class for Platalina (genus).
/// NCBI TaxId: 148085
/// </summary>
public abstract class Platalina : Phyllostomidae, IPlatalina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platalina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148085;

    /// <inheritdoc />
    public virtual string GenusName => "Platalina";

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
