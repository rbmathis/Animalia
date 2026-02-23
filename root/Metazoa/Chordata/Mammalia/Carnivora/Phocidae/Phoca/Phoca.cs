using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Phoca;

/// <summary>
/// Abstract class for Phoca (genus).
/// NCBI TaxId: 9717
/// </summary>
public abstract class Phoca : Phocidae, IPhoca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phoca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9717;

    /// <inheritdoc />
    public virtual string GenusName => "Phoca";

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
