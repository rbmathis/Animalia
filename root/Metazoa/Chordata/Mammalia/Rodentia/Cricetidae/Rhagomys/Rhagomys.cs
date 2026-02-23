using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rhagomys;

/// <summary>
/// Abstract class for Rhagomys (genus).
/// NCBI TaxId: 221578
/// </summary>
public abstract class Rhagomys : Cricetidae, IRhagomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhagomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221578;

    /// <inheritdoc />
    public virtual string GenusName => "Rhagomys";

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
