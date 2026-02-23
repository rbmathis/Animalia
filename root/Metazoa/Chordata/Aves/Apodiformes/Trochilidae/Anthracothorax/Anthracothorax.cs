using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Anthracothorax;

/// <summary>
/// Abstract class for Anthracothorax (genus).
/// NCBI TaxId: 118179
/// </summary>
public abstract class Anthracothorax : Trochilidae, IAnthracothorax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anthracothorax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118179;

    /// <inheritdoc />
    public virtual string GenusName => "Anthracothorax";

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
