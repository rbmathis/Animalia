using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Mesotes;

/// <summary>
/// Abstract class for Mesotes (genus).
/// NCBI TaxId: 3148940
/// </summary>
public abstract class Mesotes : Colubridae, IMesotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mesotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3148940;

    /// <inheritdoc />
    public virtual string GenusName => "Mesotes";

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
