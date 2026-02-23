using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Lycodon;

/// <summary>
/// Abstract class for Lycodon (genus).
/// NCBI TaxId: 39095
/// </summary>
public abstract class Lycodon : Colubridae, ILycodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lycodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39095;

    /// <inheritdoc />
    public virtual string GenusName => "Lycodon";

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
