using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hyperoliidae.Cryptothylax;

/// <summary>
/// Abstract class for Cryptothylax (genus).
/// NCBI TaxId: 143560
/// </summary>
public abstract class Cryptothylax : Hyperoliidae, ICryptothylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptothylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143560;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptothylax";

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
