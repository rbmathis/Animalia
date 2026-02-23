using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Emballonuridae.Cormura;

/// <summary>
/// Abstract class for Cormura (genus).
/// NCBI TaxId: 249011
/// </summary>
public abstract class Cormura : Emballonuridae, ICormura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cormura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 249011;

    /// <inheritdoc />
    public virtual string GenusName => "Cormura";

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
