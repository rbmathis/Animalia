using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Neodon;

/// <summary>
/// Abstract class for Neodon (genus).
/// NCBI TaxId: 465452
/// </summary>
public abstract class Neodon : Cricetidae, INeodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 465452;

    /// <inheritdoc />
    public virtual string GenusName => "Neodon";

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
