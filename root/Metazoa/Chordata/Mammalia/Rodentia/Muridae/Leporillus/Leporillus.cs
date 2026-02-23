using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Leporillus;

/// <summary>
/// Abstract class for Leporillus (genus).
/// NCBI TaxId: 253151
/// </summary>
public abstract class Leporillus : Muridae, ILeporillus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leporillus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 253151;

    /// <inheritdoc />
    public virtual string GenusName => "Leporillus";

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
