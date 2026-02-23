using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tomodon;

/// <summary>
/// Abstract class for Tomodon (genus).
/// NCBI TaxId: 666124
/// </summary>
public abstract class Tomodon : Dipsadidae, ITomodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tomodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 666124;

    /// <inheritdoc />
    public virtual string GenusName => "Tomodon";

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
