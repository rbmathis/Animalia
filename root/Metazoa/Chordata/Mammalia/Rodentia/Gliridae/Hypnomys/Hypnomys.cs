using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Gliridae.Hypnomys;

/// <summary>
/// Abstract class for Hypnomys (genus).
/// NCBI TaxId: 2033400
/// </summary>
public abstract class Hypnomys : Gliridae, IHypnomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hypnomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2033400;

    /// <inheritdoc />
    public virtual string GenusName => "Hypnomys";

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
