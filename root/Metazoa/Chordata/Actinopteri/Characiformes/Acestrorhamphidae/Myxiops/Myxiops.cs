using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Myxiops;

/// <summary>
/// Abstract class for Myxiops (genus).
/// NCBI TaxId: 930355
/// </summary>
public abstract class Myxiops : Acestrorhamphidae, IMyxiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myxiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930355;

    /// <inheritdoc />
    public virtual string GenusName => "Myxiops";

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
