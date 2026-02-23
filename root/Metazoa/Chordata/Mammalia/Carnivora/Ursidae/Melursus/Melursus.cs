using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Ursidae.Melursus;

/// <summary>
/// Abstract class for Melursus (genus).
/// NCBI TaxId: 9635
/// </summary>
public abstract class Melursus : Ursidae, IMelursus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melursus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9635;

    /// <inheritdoc />
    public virtual string GenusName => "Melursus";

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
