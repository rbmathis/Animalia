using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Trogopterus;

/// <summary>
/// Abstract class for Trogopterus (genus).
/// NCBI TaxId: 226818
/// </summary>
public abstract class Trogopterus : Sciuridae, ITrogopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Trogopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 226818;

    /// <inheritdoc />
    public virtual string GenusName => "Trogopterus";

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
