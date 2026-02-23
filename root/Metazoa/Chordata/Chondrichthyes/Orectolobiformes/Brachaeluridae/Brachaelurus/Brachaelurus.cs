using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Brachaeluridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Brachaeluridae.Brachaelurus;

/// <summary>
/// Abstract class for Brachaelurus (genus).
/// NCBI TaxId: 582433
/// </summary>
public abstract class Brachaelurus : Brachaeluridae, IBrachaelurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Brachaelurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 582433;

    /// <inheritdoc />
    public virtual string GenusName => "Brachaelurus";

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
