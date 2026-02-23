using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Telmatherinidae.Tominanga;

/// <summary>
/// Abstract class for Tominanga (genus).
/// NCBI TaxId: 390279
/// </summary>
public abstract class Tominanga : Telmatherinidae, ITominanga
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tominanga";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 390279;

    /// <inheritdoc />
    public virtual string GenusName => "Tominanga";

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
