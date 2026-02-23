using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Phocidae.Halichoerus;

/// <summary>
/// Abstract class for Halichoerus (genus).
/// NCBI TaxId: 9710
/// </summary>
public abstract class Halichoerus : Phocidae, IHalichoerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halichoerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9710;

    /// <inheritdoc />
    public virtual string GenusName => "Halichoerus";

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
