using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Chlamydosaurus;

/// <summary>
/// Abstract class for Chlamydosaurus (genus).
/// NCBI TaxId: 103698
/// </summary>
public abstract class Chlamydosaurus : Agamidae, IChlamydosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlamydosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103698;

    /// <inheritdoc />
    public virtual string GenusName => "Chlamydosaurus";

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
