using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Vernaya;

/// <summary>
/// Abstract class for Vernaya (genus).
/// NCBI TaxId: 2073146
/// </summary>
public abstract class Vernaya : Muridae, IVernaya
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Vernaya";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2073146;

    /// <inheritdoc />
    public virtual string GenusName => "Vernaya";

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
