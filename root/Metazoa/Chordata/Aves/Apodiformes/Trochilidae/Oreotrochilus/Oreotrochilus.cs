using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Oreotrochilus;

/// <summary>
/// Abstract class for Oreotrochilus (genus).
/// NCBI TaxId: 56662
/// </summary>
public abstract class Oreotrochilus : Trochilidae, IOreotrochilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oreotrochilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56662;

    /// <inheritdoc />
    public virtual string GenusName => "Oreotrochilus";

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
