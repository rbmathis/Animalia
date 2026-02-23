using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Heimyscus;

/// <summary>
/// Abstract class for Heimyscus (genus).
/// NCBI TaxId: 209870
/// </summary>
public abstract class Heimyscus : Muridae, IHeimyscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heimyscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209870;

    /// <inheritdoc />
    public virtual string GenusName => "Heimyscus";

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
