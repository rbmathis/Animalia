using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Syngnathidae.Phyllopteryx;

/// <summary>
/// Abstract class for Phyllopteryx (genus).
/// NCBI TaxId: 161468
/// </summary>
public abstract class Phyllopteryx : Syngnathidae, IPhyllopteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllopteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 161468;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllopteryx";

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
