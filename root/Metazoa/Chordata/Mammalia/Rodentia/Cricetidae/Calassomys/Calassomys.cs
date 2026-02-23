using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Calassomys;

/// <summary>
/// Abstract class for Calassomys (genus).
/// NCBI TaxId: 1868921
/// </summary>
public abstract class Calassomys : Cricetidae, ICalassomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calassomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1868921;

    /// <inheritdoc />
    public virtual string GenusName => "Calassomys";

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
