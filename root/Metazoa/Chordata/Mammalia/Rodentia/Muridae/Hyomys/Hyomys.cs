using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hyomys;

/// <summary>
/// Abstract class for Hyomys (genus).
/// NCBI TaxId: 337220
/// </summary>
public abstract class Hyomys : Muridae, IHyomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 337220;

    /// <inheritdoc />
    public virtual string GenusName => "Hyomys";

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
