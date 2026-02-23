using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gracilimus;

/// <summary>
/// Abstract class for Gracilimus (genus).
/// NCBI TaxId: 3452917
/// </summary>
public abstract class Gracilimus : Muridae, IGracilimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gracilimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3452917;

    /// <inheritdoc />
    public virtual string GenusName => "Gracilimus";

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
