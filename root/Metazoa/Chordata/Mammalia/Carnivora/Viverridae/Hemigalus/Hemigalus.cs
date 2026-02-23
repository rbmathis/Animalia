using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Viverridae.Hemigalus;

/// <summary>
/// Abstract class for Hemigalus (genus).
/// NCBI TaxId: 94191
/// </summary>
public abstract class Hemigalus : Viverridae, IHemigalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemigalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94191;

    /// <inheritdoc />
    public virtual string GenusName => "Hemigalus";

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
