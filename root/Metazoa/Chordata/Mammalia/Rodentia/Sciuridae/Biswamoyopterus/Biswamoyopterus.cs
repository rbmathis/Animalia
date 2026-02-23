using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Biswamoyopterus;

/// <summary>
/// Abstract class for Biswamoyopterus (genus).
/// NCBI TaxId: 2599450
/// </summary>
public abstract class Biswamoyopterus : Sciuridae, IBiswamoyopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Biswamoyopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2599450;

    /// <inheritdoc />
    public virtual string GenusName => "Biswamoyopterus";

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
