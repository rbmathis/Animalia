using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Ictidomys;

/// <summary>
/// Abstract class for Ictidomys (genus).
/// NCBI TaxId: 1141640
/// </summary>
public abstract class Ictidomys : Sciuridae, IIctidomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ictidomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1141640;

    /// <inheritdoc />
    public virtual string GenusName => "Ictidomys";

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
