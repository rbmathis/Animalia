using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Parastremma;

/// <summary>
/// Abstract class for Parastremma (genus).
/// NCBI TaxId: 2870518
/// </summary>
public abstract class Parastremma : Acestrorhamphidae, IParastremma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parastremma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2870518;

    /// <inheritdoc />
    public virtual string GenusName => "Parastremma";

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
