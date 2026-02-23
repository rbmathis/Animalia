using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamiops;

/// <summary>
/// Abstract class for Tamiops (genus).
/// NCBI TaxId: 226576
/// </summary>
public abstract class Tamiops : Sciuridae, ITamiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tamiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226576;

    /// <inheritdoc />
    public virtual string GenusName => "Tamiops";

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
