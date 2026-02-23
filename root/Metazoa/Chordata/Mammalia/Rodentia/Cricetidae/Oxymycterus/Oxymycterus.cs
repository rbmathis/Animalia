using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oxymycterus;

/// <summary>
/// Abstract class for Oxymycterus (genus).
/// NCBI TaxId: 29124
/// </summary>
public abstract class Oxymycterus : Cricetidae, IOxymycterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxymycterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29124;

    /// <inheritdoc />
    public virtual string GenusName => "Oxymycterus";

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
