using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Eropeplus;

/// <summary>
/// Abstract class for Eropeplus (genus).
/// NCBI TaxId: 2716777
/// </summary>
public abstract class Eropeplus : Muridae, IEropeplus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eropeplus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2716777;

    /// <inheritdoc />
    public virtual string GenusName => "Eropeplus";

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
