using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

/// <summary>
/// Abstract class for Praomys (genus).
/// NCBI TaxId: 10111
/// </summary>
public abstract class Praomys : Muridae, IPraomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Praomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10111;

    /// <inheritdoc />
    public virtual string GenusName => "Praomys";

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
