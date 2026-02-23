using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Basilinna;

/// <summary>
/// Abstract class for Basilinna (genus).
/// NCBI TaxId: 2744915
/// </summary>
public abstract class Basilinna : Trochilidae, IBasilinna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Basilinna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2744915;

    /// <inheritdoc />
    public virtual string GenusName => "Basilinna";

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
