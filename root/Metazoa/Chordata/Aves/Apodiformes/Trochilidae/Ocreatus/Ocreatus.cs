using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Ocreatus;

/// <summary>
/// Abstract class for Ocreatus (genus).
/// NCBI TaxId: 304660
/// </summary>
public abstract class Ocreatus : Trochilidae, IOcreatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ocreatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304660;

    /// <inheritdoc />
    public virtual string GenusName => "Ocreatus";

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
