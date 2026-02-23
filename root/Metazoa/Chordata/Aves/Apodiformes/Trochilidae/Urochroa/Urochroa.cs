using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Urochroa;

/// <summary>
/// Abstract class for Urochroa (genus).
/// NCBI TaxId: 472915
/// </summary>
public abstract class Urochroa : Trochilidae, IUrochroa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urochroa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 472915;

    /// <inheritdoc />
    public virtual string GenusName => "Urochroa";

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
