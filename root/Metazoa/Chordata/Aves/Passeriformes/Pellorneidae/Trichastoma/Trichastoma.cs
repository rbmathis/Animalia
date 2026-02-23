using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Trichastoma;

/// <summary>
/// Abstract class for Trichastoma (genus).
/// NCBI TaxId: 135978
/// </summary>
public abstract class Trichastoma : Pellorneidae, ITrichastoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trichastoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135978;

    /// <inheritdoc />
    public virtual string GenusName => "Trichastoma";

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
