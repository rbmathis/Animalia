using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Monognathidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Monognathidae.Monognathus;

/// <summary>
/// Abstract class for Monognathus (genus).
/// NCBI TaxId: 556249
/// </summary>
public abstract class Monognathus : Monognathidae, IMonognathus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Monognathus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 556249;

    /// <inheritdoc />
    public virtual string GenusName => "Monognathus";

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
