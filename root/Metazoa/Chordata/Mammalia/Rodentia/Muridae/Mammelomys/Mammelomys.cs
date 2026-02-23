using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mammelomys;

/// <summary>
/// Abstract class for Mammelomys (genus).
/// NCBI TaxId: 442582
/// </summary>
public abstract class Mammelomys : Muridae, IMammelomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mammelomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 442582;

    /// <inheritdoc />
    public virtual string GenusName => "Mammelomys";

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
