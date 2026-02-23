using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Canidae.Lycalopex;

/// <summary>
/// Abstract class for Lycalopex (genus).
/// NCBI TaxId: 425200
/// </summary>
public abstract class Lycalopex : Canidae, ILycalopex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycalopex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425200;

    /// <inheritdoc />
    public virtual string GenusName => "Lycalopex";

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
