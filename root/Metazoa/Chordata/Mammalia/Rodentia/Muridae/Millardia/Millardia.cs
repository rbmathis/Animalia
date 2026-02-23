using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Millardia;

/// <summary>
/// Abstract class for Millardia (genus).
/// NCBI TaxId: 121582
/// </summary>
public abstract class Millardia : Muridae, IMillardia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Millardia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121582;

    /// <inheritdoc />
    public virtual string GenusName => "Millardia";

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
