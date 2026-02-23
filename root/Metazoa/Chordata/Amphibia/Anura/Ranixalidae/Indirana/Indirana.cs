using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranixalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranixalidae.Indirana;

/// <summary>
/// Abstract class for Indirana (genus).
/// NCBI TaxId: 129007
/// </summary>
public abstract class Indirana : Ranixalidae, IIndirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Indirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129007;

    /// <inheritdoc />
    public virtual string GenusName => "Indirana";

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
