using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Corucia;

/// <summary>
/// Abstract class for Corucia (genus).
/// NCBI TaxId: 96730
/// </summary>
public abstract class Corucia : Scincidae, ICorucia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Corucia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 96730;

    /// <inheritdoc />
    public virtual string GenusName => "Corucia";

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
