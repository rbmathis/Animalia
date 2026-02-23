using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Ephalophis;

/// <summary>
/// Abstract class for Ephalophis (genus).
/// NCBI TaxId: 663305
/// </summary>
public abstract class Ephalophis : Elapidae, IEphalophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ephalophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 663305;

    /// <inheritdoc />
    public virtual string GenusName => "Ephalophis";

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
