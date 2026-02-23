using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Rhinocheilus;

/// <summary>
/// Abstract class for Rhinocheilus (genus).
/// NCBI TaxId: 94900
/// </summary>
public abstract class Rhinocheilus : Colubridae, IRhinocheilus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhinocheilus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 94900;

    /// <inheritdoc />
    public virtual string GenusName => "Rhinocheilus";

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
