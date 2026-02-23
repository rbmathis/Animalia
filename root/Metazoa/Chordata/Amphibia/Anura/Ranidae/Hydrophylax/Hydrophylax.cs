using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Hydrophylax;

/// <summary>
/// Abstract class for Hydrophylax (genus).
/// NCBI TaxId: 1729444
/// </summary>
public abstract class Hydrophylax : Ranidae, IHydrophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1729444;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrophylax";

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
