using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Allocricetulus;

/// <summary>
/// Abstract class for Allocricetulus (genus).
/// NCBI TaxId: 329633
/// </summary>
public abstract class Allocricetulus : Cricetidae, IAllocricetulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allocricetulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329633;

    /// <inheritdoc />
    public virtual string GenusName => "Allocricetulus";

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
