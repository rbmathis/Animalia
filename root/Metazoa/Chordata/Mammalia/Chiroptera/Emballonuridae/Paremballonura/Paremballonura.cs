using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Paremballonura;

/// <summary>
/// Abstract class for Paremballonura (genus).
/// NCBI TaxId: 3371047
/// </summary>
public abstract class Paremballonura : Emballonuridae, IParemballonura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paremballonura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3371047;

    /// <inheritdoc />
    public virtual string GenusName => "Paremballonura";

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
