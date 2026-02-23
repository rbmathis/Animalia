using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Bauerius;

/// <summary>
/// Abstract class for Bauerius (genus).
/// NCBI TaxId: 2936267
/// </summary>
public abstract class Bauerius : Gekkonidae, IBauerius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bauerius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2936267;

    /// <inheritdoc />
    public virtual string GenusName => "Bauerius";

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
