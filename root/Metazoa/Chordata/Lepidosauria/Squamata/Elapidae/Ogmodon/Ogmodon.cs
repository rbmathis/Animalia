using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Elapidae.Ogmodon;

/// <summary>
/// Abstract class for Ogmodon (genus).
/// NCBI TaxId: 1413205
/// </summary>
public abstract class Ogmodon : Elapidae, IOgmodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ogmodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1413205;

    /// <inheritdoc />
    public virtual string GenusName => "Ogmodon";

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
