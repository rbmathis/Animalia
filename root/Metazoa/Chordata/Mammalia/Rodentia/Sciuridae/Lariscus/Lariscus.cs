using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Lariscus;

/// <summary>
/// Abstract class for Lariscus (genus).
/// NCBI TaxId: 226557
/// </summary>
public abstract class Lariscus : Sciuridae, ILariscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lariscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226557;

    /// <inheritdoc />
    public virtual string GenusName => "Lariscus";

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
