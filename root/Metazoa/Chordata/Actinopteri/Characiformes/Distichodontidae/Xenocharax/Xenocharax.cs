using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Distichodontidae.Xenocharax;

/// <summary>
/// Abstract class for Xenocharax (genus).
/// NCBI TaxId: 304087
/// </summary>
public abstract class Xenocharax : Distichodontidae, IXenocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Xenocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304087;

    /// <inheritdoc />
    public virtual string GenusName => "Xenocharax";

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
