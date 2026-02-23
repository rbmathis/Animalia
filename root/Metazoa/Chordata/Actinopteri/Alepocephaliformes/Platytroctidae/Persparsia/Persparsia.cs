using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Platytroctidae.Persparsia;

/// <summary>
/// Abstract class for Persparsia (genus).
/// NCBI TaxId: 1867358
/// </summary>
public abstract class Persparsia : Platytroctidae, IPersparsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Persparsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1867358;

    /// <inheritdoc />
    public virtual string GenusName => "Persparsia";

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
