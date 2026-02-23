using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Scotozous;

/// <summary>
/// Abstract class for Scotozous (genus).
/// NCBI TaxId: 2830903
/// </summary>
public abstract class Scotozous : Vespertilionidae, IScotozous
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scotozous";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2830903;

    /// <inheritdoc />
    public virtual string GenusName => "Scotozous";

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
