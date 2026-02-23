using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Monilesaurus;

/// <summary>
/// Abstract class for Monilesaurus (genus).
/// NCBI TaxId: 2558915
/// </summary>
public abstract class Monilesaurus : Agamidae, IMonilesaurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monilesaurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2558915;

    /// <inheritdoc />
    public virtual string GenusName => "Monilesaurus";

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
