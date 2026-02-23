using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Vandeleuria;

/// <summary>
/// Abstract class for Vandeleuria (genus).
/// NCBI TaxId: 491877
/// </summary>
public abstract class Vandeleuria : Muridae, IVandeleuria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vandeleuria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 491877;

    /// <inheritdoc />
    public virtual string GenusName => "Vandeleuria";

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
