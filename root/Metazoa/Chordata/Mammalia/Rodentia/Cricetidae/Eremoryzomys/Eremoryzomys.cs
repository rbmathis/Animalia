using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Eremoryzomys;

/// <summary>
/// Abstract class for Eremoryzomys (genus).
/// NCBI TaxId: 655581
/// </summary>
public abstract class Eremoryzomys : Cricetidae, IEremoryzomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eremoryzomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 655581;

    /// <inheritdoc />
    public virtual string GenusName => "Eremoryzomys";

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
