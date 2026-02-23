using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Dicroglossidae.Sphaerotheca;

/// <summary>
/// Abstract class for Sphaerotheca (genus).
/// NCBI TaxId: 127028
/// </summary>
public abstract class Sphaerotheca : Dicroglossidae, ISphaerotheca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sphaerotheca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 127028;

    /// <inheritdoc />
    public virtual string GenusName => "Sphaerotheca";

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
