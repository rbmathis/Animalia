using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Thomasomys;

/// <summary>
/// Abstract class for Thomasomys (genus).
/// NCBI TaxId: 29130
/// </summary>
public abstract class Thomasomys : Cricetidae, IThomasomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Thomasomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 29130;

    /// <inheritdoc />
    public virtual string GenusName => "Thomasomys";

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
