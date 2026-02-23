using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Chelemys;

/// <summary>
/// Abstract class for Chelemys (genus).
/// NCBI TaxId: 29108
/// </summary>
public abstract class Chelemys : Cricetidae, IChelemys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelemys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29108;

    /// <inheritdoc />
    public virtual string GenusName => "Chelemys";

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
