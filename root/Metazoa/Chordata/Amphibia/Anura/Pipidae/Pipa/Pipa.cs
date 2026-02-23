using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pipidae.Pipa;

/// <summary>
/// Abstract class for Pipa (genus).
/// NCBI TaxId: 191479
/// </summary>
public abstract class Pipa : Pipidae, IPipa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pipa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 191479;

    /// <inheritdoc />
    public virtual string GenusName => "Pipa";

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
