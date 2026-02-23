using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Asellia;

/// <summary>
/// Abstract class for Asellia (genus).
/// NCBI TaxId: 578339
/// </summary>
public abstract class Asellia : Hipposideridae, IAsellia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Asellia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 578339;

    /// <inheritdoc />
    public virtual string GenusName => "Asellia";

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
