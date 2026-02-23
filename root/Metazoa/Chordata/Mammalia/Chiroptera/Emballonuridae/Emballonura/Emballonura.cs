using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Emballonura;

/// <summary>
/// Abstract class for Emballonura (genus).
/// NCBI TaxId: 110939
/// </summary>
public abstract class Emballonura : Emballonuridae, IEmballonura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Emballonura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110939;

    /// <inheritdoc />
    public virtual string GenusName => "Emballonura";

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
