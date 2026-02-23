using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Oxyuranus;

/// <summary>
/// Abstract class for Oxyuranus (genus).
/// NCBI TaxId: 8666
/// </summary>
public abstract class Oxyuranus : Elapidae, IOxyuranus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxyuranus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8666;

    /// <inheritdoc />
    public virtual string GenusName => "Oxyuranus";

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
