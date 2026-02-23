using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Herpestidae.Ichneumia;

/// <summary>
/// Abstract class for Ichneumia (genus).
/// NCBI TaxId: 205598
/// </summary>
public abstract class Ichneumia : Herpestidae, IIchneumia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ichneumia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 205598;

    /// <inheritdoc />
    public virtual string GenusName => "Ichneumia";

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
