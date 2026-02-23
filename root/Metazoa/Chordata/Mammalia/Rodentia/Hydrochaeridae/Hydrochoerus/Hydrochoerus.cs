using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hydrochaeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Hydrochaeridae.Hydrochoerus;

/// <summary>
/// Abstract class for Hydrochoerus (genus).
/// NCBI TaxId: 10148
/// </summary>
public abstract class Hydrochoerus : Hydrochaeridae, IHydrochoerus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydrochoerus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 10148;

    /// <inheritdoc />
    public virtual string GenusName => "Hydrochoerus";

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
