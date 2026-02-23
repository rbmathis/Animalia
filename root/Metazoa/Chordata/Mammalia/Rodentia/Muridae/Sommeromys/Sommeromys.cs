using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Sommeromys;

/// <summary>
/// Abstract class for Sommeromys (genus).
/// NCBI TaxId: 1795470
/// </summary>
public abstract class Sommeromys : Muridae, ISommeromys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sommeromys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1795470;

    /// <inheritdoc />
    public virtual string GenusName => "Sommeromys";

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
