using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Hylopetes;

/// <summary>
/// Abstract class for Hylopetes (genus).
/// NCBI TaxId: 100944
/// </summary>
public abstract class Hylopetes : Sciuridae, IHylopetes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylopetes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 100944;

    /// <inheritdoc />
    public virtual string GenusName => "Hylopetes";

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
