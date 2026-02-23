using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Cyttarops;

/// <summary>
/// Abstract class for Cyttarops (genus).
/// NCBI TaxId: 409019
/// </summary>
public abstract class Cyttarops : Emballonuridae, ICyttarops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyttarops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 409019;

    /// <inheritdoc />
    public virtual string GenusName => "Cyttarops";

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
