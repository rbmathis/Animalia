using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Dibernardia;

/// <summary>
/// Abstract class for Dibernardia (genus).
/// NCBI TaxId: 3148933
/// </summary>
public abstract class Dibernardia : Colubridae, IDibernardia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dibernardia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148933;

    /// <inheritdoc />
    public virtual string GenusName => "Dibernardia";

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
