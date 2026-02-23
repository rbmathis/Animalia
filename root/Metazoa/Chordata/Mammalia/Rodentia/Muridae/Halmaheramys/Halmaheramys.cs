using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Halmaheramys;

/// <summary>
/// Abstract class for Halmaheramys (genus).
/// NCBI TaxId: 1405176
/// </summary>
public abstract class Halmaheramys : Muridae, IHalmaheramys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Halmaheramys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1405176;

    /// <inheritdoc />
    public virtual string GenusName => "Halmaheramys";

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
