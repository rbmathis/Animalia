using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Palleon;

/// <summary>
/// Abstract class for Palleon (genus).
/// NCBI TaxId: 1538431
/// </summary>
public abstract class Palleon : Chamaeleonidae, IPalleon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Palleon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1538431;

    /// <inheritdoc />
    public virtual string GenusName => "Palleon";

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
