using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Threnetes;

/// <summary>
/// Abstract class for Threnetes (genus).
/// NCBI TaxId: 214670
/// </summary>
public abstract class Threnetes : Trochilidae, IThrenetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Threnetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 214670;

    /// <inheritdoc />
    public virtual string GenusName => "Threnetes";

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
