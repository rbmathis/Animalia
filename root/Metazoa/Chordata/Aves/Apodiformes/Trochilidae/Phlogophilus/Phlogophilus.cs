using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Phlogophilus;

/// <summary>
/// Abstract class for Phlogophilus (genus).
/// NCBI TaxId: 304675
/// </summary>
public abstract class Phlogophilus : Trochilidae, IPhlogophilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phlogophilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304675;

    /// <inheritdoc />
    public virtual string GenusName => "Phlogophilus";

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
