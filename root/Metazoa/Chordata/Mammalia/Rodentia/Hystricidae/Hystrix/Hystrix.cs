using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hystricidae.Hystrix;

/// <summary>
/// Abstract class for Hystrix (genus).
/// NCBI TaxId: 10136
/// </summary>
public abstract class Hystrix : Hystricidae, IHystrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hystrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10136;

    /// <inheritdoc />
    public virtual string GenusName => "Hystrix";

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
