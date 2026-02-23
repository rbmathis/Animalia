using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Podoxymys;

/// <summary>
/// Abstract class for Podoxymys (genus).
/// NCBI TaxId: 1604869
/// </summary>
public abstract class Podoxymys : Cricetidae, IPodoxymys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Podoxymys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1604869;

    /// <inheritdoc />
    public virtual string GenusName => "Podoxymys";

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
