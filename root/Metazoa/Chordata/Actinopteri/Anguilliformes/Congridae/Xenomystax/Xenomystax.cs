using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Xenomystax;

/// <summary>
/// Abstract class for Xenomystax (genus).
/// NCBI TaxId: 391212
/// </summary>
public abstract class Xenomystax : Congridae, IXenomystax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenomystax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391212;

    /// <inheritdoc />
    public virtual string GenusName => "Xenomystax";

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
