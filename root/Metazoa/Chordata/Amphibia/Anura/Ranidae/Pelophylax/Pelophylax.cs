using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Pelophylax;

/// <summary>
/// Abstract class for Pelophylax (genus).
/// NCBI TaxId: 121164
/// </summary>
public abstract class Pelophylax : Ranidae, IPelophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pelophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121164;

    /// <inheritdoc />
    public virtual string GenusName => "Pelophylax";

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
