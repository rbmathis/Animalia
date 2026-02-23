using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Rachoviscus;

/// <summary>
/// Abstract class for Rachoviscus (genus).
/// NCBI TaxId: 681935
/// </summary>
public abstract class Rachoviscus : Acestrorhamphidae, IRachoviscus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rachoviscus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681935;

    /// <inheritdoc />
    public virtual string GenusName => "Rachoviscus";

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
