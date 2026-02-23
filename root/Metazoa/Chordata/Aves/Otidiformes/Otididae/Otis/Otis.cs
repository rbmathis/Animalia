using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Otis;

/// <summary>
/// Abstract class for Otis (genus).
/// NCBI TaxId: 73106
/// </summary>
public abstract class Otis : Otididae, IOtis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Otis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 73106;

    /// <inheritdoc />
    public virtual string GenusName => "Otis";

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
