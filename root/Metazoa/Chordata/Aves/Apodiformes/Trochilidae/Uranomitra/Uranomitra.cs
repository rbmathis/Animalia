using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Uranomitra;

/// <summary>
/// Abstract class for Uranomitra (genus).
/// NCBI TaxId: 3150861
/// </summary>
public abstract class Uranomitra : Trochilidae, IUranomitra
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uranomitra";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150861;

    /// <inheritdoc />
    public virtual string GenusName => "Uranomitra";

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
