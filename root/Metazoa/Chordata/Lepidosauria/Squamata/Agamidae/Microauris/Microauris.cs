using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Microauris;

/// <summary>
/// Abstract class for Microauris (genus).
/// NCBI TaxId: 2572878
/// </summary>
public abstract class Microauris : Agamidae, IMicroauris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microauris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2572878;

    /// <inheritdoc />
    public virtual string GenusName => "Microauris";

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
