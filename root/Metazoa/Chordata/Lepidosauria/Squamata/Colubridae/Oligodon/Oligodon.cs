using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Oligodon;

/// <summary>
/// Abstract class for Oligodon (genus).
/// NCBI TaxId: 46272
/// </summary>
public abstract class Oligodon : Colubridae, IOligodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oligodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46272;

    /// <inheritdoc />
    public virtual string GenusName => "Oligodon";

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
