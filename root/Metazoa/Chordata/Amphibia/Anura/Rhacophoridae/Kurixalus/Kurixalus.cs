using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Kurixalus;

/// <summary>
/// Abstract class for Kurixalus (genus).
/// NCBI TaxId: 311778
/// </summary>
public abstract class Kurixalus : Rhacophoridae, IKurixalus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kurixalus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 311778;

    /// <inheritdoc />
    public virtual string GenusName => "Kurixalus";

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
