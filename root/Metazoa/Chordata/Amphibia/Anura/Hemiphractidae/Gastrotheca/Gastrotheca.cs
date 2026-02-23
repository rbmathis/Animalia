using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hemiphractidae.Gastrotheca;

/// <summary>
/// Abstract class for Gastrotheca (genus).
/// NCBI TaxId: 8419
/// </summary>
public abstract class Gastrotheca : Hemiphractidae, IGastrotheca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gastrotheca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8419;

    /// <inheritdoc />
    public virtual string GenusName => "Gastrotheca";

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
