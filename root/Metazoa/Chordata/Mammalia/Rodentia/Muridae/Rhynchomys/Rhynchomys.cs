using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhynchomys;

/// <summary>
/// Abstract class for Rhynchomys (genus).
/// NCBI TaxId: 237999
/// </summary>
public abstract class Rhynchomys : Muridae, IRhynchomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 237999;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchomys";

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
