using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Tiaris;

/// <summary>
/// Abstract class for Tiaris (genus).
/// NCBI TaxId: 93067
/// </summary>
public abstract class Tiaris : Thraupidae, ITiaris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tiaris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 93067;

    /// <inheritdoc />
    public virtual string GenusName => "Tiaris";

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
