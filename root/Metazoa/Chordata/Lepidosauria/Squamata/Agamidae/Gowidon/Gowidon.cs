using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Agamidae.Gowidon;

/// <summary>
/// Abstract class for Gowidon (genus).
/// NCBI TaxId: 2025344
/// </summary>
public abstract class Gowidon : Agamidae, IGowidon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gowidon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2025344;

    /// <inheritdoc />
    public virtual string GenusName => "Gowidon";

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
