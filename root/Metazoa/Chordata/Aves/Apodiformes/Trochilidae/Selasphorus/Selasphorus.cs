using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Selasphorus;

/// <summary>
/// Abstract class for Selasphorus (genus).
/// NCBI TaxId: 29059
/// </summary>
public abstract class Selasphorus : Trochilidae, ISelasphorus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Selasphorus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29059;

    /// <inheritdoc />
    public virtual string GenusName => "Selasphorus";

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
