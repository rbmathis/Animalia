using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Alsophylax;

/// <summary>
/// Abstract class for Alsophylax (genus).
/// NCBI TaxId: 1208010
/// </summary>
public abstract class Alsophylax : Gekkonidae, IAlsophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alsophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1208010;

    /// <inheritdoc />
    public virtual string GenusName => "Alsophylax";

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
