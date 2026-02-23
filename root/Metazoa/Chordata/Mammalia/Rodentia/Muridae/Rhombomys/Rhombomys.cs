using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhombomys;

/// <summary>
/// Abstract class for Rhombomys (genus).
/// NCBI TaxId: 186473
/// </summary>
public abstract class Rhombomys : Muridae, IRhombomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhombomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186473;

    /// <inheritdoc />
    public virtual string GenusName => "Rhombomys";

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
