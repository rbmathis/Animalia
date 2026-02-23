using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Arcanumophis;

/// <summary>
/// Abstract class for Arcanumophis (genus).
/// NCBI TaxId: 3144963
/// </summary>
public abstract class Arcanumophis : Colubridae, IArcanumophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Arcanumophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3144963;

    /// <inheritdoc />
    public virtual string GenusName => "Arcanumophis";

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
