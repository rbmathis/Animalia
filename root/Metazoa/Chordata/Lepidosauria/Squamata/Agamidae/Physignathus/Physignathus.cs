using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Physignathus;

/// <summary>
/// Abstract class for Physignathus (genus).
/// NCBI TaxId: 52199
/// </summary>
public abstract class Physignathus : Agamidae, IPhysignathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Physignathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52199;

    /// <inheritdoc />
    public virtual string GenusName => "Physignathus";

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
