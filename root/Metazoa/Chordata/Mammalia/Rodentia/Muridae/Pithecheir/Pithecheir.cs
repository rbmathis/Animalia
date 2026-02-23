using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pithecheir;

/// <summary>
/// Abstract class for Pithecheir (genus).
/// NCBI TaxId: 2060318
/// </summary>
public abstract class Pithecheir : Muridae, IPithecheir
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pithecheir";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2060318;

    /// <inheritdoc />
    public virtual string GenusName => "Pithecheir";

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
