using AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Tinamiformes.Tinamidae.Tinamus;

/// <summary>
/// Abstract class for Tinamus (genus).
/// NCBI TaxId: 30467
/// </summary>
public abstract class Tinamus : Tinamidae, ITinamus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tinamus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30467;

    /// <inheritdoc />
    public virtual string GenusName => "Tinamus";

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
