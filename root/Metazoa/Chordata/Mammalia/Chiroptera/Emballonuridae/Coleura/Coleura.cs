using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Coleura;

/// <summary>
/// Abstract class for Coleura (genus).
/// NCBI TaxId: 461397
/// </summary>
public abstract class Coleura : Emballonuridae, IColeura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coleura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461397;

    /// <inheritdoc />
    public virtual string GenusName => "Coleura";

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
