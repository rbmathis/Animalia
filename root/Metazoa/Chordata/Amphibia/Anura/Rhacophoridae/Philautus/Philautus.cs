using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Philautus;

/// <summary>
/// Abstract class for Philautus (genus).
/// NCBI TaxId: 68429
/// </summary>
public abstract class Philautus : Rhacophoridae, IPhilautus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Philautus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 68429;

    /// <inheritdoc />
    public virtual string GenusName => "Philautus";

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
