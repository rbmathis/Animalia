using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Altiphylax;

/// <summary>
/// Abstract class for Altiphylax (genus).
/// NCBI TaxId: 1353230
/// </summary>
public abstract class Altiphylax : Gekkonidae, IAltiphylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Altiphylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1353230;

    /// <inheritdoc />
    public virtual string GenusName => "Altiphylax";

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
