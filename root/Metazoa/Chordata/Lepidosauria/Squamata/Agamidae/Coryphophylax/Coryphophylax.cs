using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Coryphophylax;

/// <summary>
/// Abstract class for Coryphophylax (genus).
/// NCBI TaxId: 526408
/// </summary>
public abstract class Coryphophylax : Agamidae, ICoryphophylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coryphophylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 526408;

    /// <inheritdoc />
    public virtual string GenusName => "Coryphophylax";

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
