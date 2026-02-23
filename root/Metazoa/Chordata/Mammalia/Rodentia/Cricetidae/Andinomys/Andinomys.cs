using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Andinomys;

/// <summary>
/// Abstract class for Andinomys (genus).
/// NCBI TaxId: 118860
/// </summary>
public abstract class Andinomys : Cricetidae, IAndinomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Andinomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118860;

    /// <inheritdoc />
    public virtual string GenusName => "Andinomys";

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
