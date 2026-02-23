using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Euderma;

/// <summary>
/// Abstract class for Euderma (genus).
/// NCBI TaxId: 153290
/// </summary>
public abstract class Euderma : Vespertilionidae, IEuderma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euderma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 153290;

    /// <inheritdoc />
    public virtual string GenusName => "Euderma";

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
