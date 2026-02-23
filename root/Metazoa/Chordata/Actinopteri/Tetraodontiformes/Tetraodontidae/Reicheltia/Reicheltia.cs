using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Tetraodontidae.Reicheltia;

/// <summary>
/// Abstract class for Reicheltia (genus).
/// NCBI TaxId: 1329347
/// </summary>
public abstract class Reicheltia : Tetraodontidae, IReicheltia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Reicheltia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1329347;

    /// <inheritdoc />
    public virtual string GenusName => "Reicheltia";

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
