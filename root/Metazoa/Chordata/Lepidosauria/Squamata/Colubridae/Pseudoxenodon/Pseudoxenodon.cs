using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pseudoxenodon;

/// <summary>
/// Abstract class for Pseudoxenodon (genus).
/// NCBI TaxId: 186565
/// </summary>
public abstract class Pseudoxenodon : Colubridae, IPseudoxenodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoxenodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186565;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoxenodon";

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
