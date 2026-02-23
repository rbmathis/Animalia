using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Tatia;

/// <summary>
/// Abstract class for Tatia (genus).
/// NCBI TaxId: 238665
/// </summary>
public abstract class Tatia : Auchenipteridae, ITatia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tatia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 238665;

    /// <inheritdoc />
    public virtual string GenusName => "Tatia";

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
