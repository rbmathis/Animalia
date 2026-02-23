using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Trochilus;

/// <summary>
/// Abstract class for Trochilus (genus).
/// NCBI TaxId: 1109100
/// </summary>
public abstract class Trochilus : Trochilidae, ITrochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1109100;

    /// <inheritdoc />
    public virtual string GenusName => "Trochilus";

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
