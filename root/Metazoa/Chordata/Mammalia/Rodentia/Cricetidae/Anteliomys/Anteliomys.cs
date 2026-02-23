using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Anteliomys;

/// <summary>
/// Abstract class for Anteliomys (genus).
/// NCBI TaxId: 3370982
/// </summary>
public abstract class Anteliomys : Cricetidae, IAnteliomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anteliomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3370982;

    /// <inheritdoc />
    public virtual string GenusName => "Anteliomys";

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
