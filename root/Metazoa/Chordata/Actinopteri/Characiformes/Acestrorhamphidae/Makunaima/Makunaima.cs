using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Acestrorhamphidae.Makunaima;

/// <summary>
/// Abstract class for Makunaima (genus).
/// NCBI TaxId: 2729156
/// </summary>
public abstract class Makunaima : Acestrorhamphidae, IMakunaima
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Makunaima";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2729156;

    /// <inheritdoc />
    public virtual string GenusName => "Makunaima";

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
