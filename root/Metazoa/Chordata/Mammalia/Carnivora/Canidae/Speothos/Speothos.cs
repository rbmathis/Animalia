using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Speothos;

/// <summary>
/// Abstract class for Speothos (genus).
/// NCBI TaxId: 68740
/// </summary>
public abstract class Speothos : Canidae, ISpeothos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Speothos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68740;

    /// <inheritdoc />
    public virtual string GenusName => "Speothos";

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
