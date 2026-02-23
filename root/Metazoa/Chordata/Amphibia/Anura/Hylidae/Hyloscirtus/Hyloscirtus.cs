using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Hyloscirtus;

/// <summary>
/// Abstract class for Hyloscirtus (genus).
/// NCBI TaxId: 374065
/// </summary>
public abstract class Hyloscirtus : Hylidae, IHyloscirtus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyloscirtus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 374065;

    /// <inheritdoc />
    public virtual string GenusName => "Hyloscirtus";

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
