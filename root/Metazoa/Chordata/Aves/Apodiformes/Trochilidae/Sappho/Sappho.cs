using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Sappho;

/// <summary>
/// Abstract class for Sappho (genus).
/// NCBI TaxId: 555343
/// </summary>
public abstract class Sappho : Trochilidae, ISappho
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sappho";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555343;

    /// <inheritdoc />
    public virtual string GenusName => "Sappho";

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
