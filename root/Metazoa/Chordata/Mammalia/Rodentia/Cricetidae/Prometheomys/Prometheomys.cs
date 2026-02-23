using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Prometheomys;

/// <summary>
/// Abstract class for Prometheomys (genus).
/// NCBI TaxId: 399231
/// </summary>
public abstract class Prometheomys : Cricetidae, IPrometheomys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prometheomys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 399231;

    /// <inheritdoc />
    public virtual string GenusName => "Prometheomys";

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
