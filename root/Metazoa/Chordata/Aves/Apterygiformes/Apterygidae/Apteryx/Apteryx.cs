using AnimalKingdom.root.Metazoa.Chordata.Aves.Apterygiformes.Apterygidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apterygiformes.Apterygidae.Apteryx;

/// <summary>
/// Abstract class for Apteryx (genus).
/// NCBI TaxId: 8821
/// </summary>
public abstract class Apteryx : Apterygidae, IApteryx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apteryx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8821;

    /// <inheritdoc />
    public virtual string GenusName => "Apteryx";

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
