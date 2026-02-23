using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Luscinia;

/// <summary>
/// Abstract class for Luscinia (genus).
/// NCBI TaxId: 52791
/// </summary>
public abstract class Luscinia : Turdidae, ILuscinia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Luscinia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 52791;

    /// <inheritdoc />
    public virtual string GenusName => "Luscinia";

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
