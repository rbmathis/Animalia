using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Aeretes;

/// <summary>
/// Abstract class for Aeretes (genus).
/// NCBI TaxId: 226694
/// </summary>
public abstract class Aeretes : Sciuridae, IAeretes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aeretes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226694;

    /// <inheritdoc />
    public virtual string GenusName => "Aeretes";

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
