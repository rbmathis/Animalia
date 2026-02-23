using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Patagona;

/// <summary>
/// Abstract class for Patagona (genus).
/// NCBI TaxId: 304666
/// </summary>
public abstract class Patagona : Trochilidae, IPatagona
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Patagona";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304666;

    /// <inheritdoc />
    public virtual string GenusName => "Patagona";

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
