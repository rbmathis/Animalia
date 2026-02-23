using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Tokudaia;

/// <summary>
/// Abstract class for Tokudaia (genus).
/// NCBI TaxId: 73108
/// </summary>
public abstract class Tokudaia : Muridae, ITokudaia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tokudaia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73108;

    /// <inheritdoc />
    public virtual string GenusName => "Tokudaia";

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
