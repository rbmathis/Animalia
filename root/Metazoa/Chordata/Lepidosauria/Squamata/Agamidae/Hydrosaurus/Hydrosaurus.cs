using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Hydrosaurus;

/// <summary>
/// Abstract class for Hydrosaurus (genus).
/// NCBI TaxId: 118206
/// </summary>
public abstract class Hydrosaurus : Agamidae, IHydrosaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrosaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118206;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrosaurus";

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
