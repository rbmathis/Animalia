using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Daptomys;

/// <summary>
/// Abstract class for Daptomys (genus).
/// NCBI TaxId: 3371031
/// </summary>
public abstract class Daptomys : Cricetidae, IDaptomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Daptomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371031;

    /// <inheritdoc />
    public virtual string GenusName => "Daptomys";

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
