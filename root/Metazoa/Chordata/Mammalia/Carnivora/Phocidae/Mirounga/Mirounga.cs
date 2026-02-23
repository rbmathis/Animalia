using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Mirounga;

/// <summary>
/// Abstract class for Mirounga (genus).
/// NCBI TaxId: 9714
/// </summary>
public abstract class Mirounga : Phocidae, IMirounga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mirounga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9714;

    /// <inheritdoc />
    public virtual string GenusName => "Mirounga";

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
