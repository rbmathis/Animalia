using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Nesomyidae.Brachyuromys;

/// <summary>
/// Abstract class for Brachyuromys (genus).
/// NCBI TaxId: 107271
/// </summary>
public abstract class Brachyuromys : Nesomyidae, IBrachyuromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachyuromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 107271;

    /// <inheritdoc />
    public virtual string GenusName => "Brachyuromys";

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
