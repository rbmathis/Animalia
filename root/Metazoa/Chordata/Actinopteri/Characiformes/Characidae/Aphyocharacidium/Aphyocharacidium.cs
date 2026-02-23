using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Aphyocharacidium;

/// <summary>
/// Abstract class for Aphyocharacidium (genus).
/// NCBI TaxId: 930292
/// </summary>
public abstract class Aphyocharacidium : Characidae, IAphyocharacidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphyocharacidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930292;

    /// <inheritdoc />
    public virtual string GenusName => "Aphyocharacidium";

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
