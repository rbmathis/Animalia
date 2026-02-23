using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hydromys;

/// <summary>
/// Abstract class for Hydromys (genus).
/// NCBI TaxId: 160447
/// </summary>
public abstract class Hydromys : Muridae, IHydromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 160447;

    /// <inheritdoc />
    public virtual string GenusName => "Hydromys";

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
