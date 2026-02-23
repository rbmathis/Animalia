using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Parulidae.Icteria;

/// <summary>
/// Abstract class for Icteria (genus).
/// NCBI TaxId: 135436
/// </summary>
public abstract class Icteria : Parulidae, IIcteria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Icteria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 135436;

    /// <inheritdoc />
    public virtual string GenusName => "Icteria";

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
