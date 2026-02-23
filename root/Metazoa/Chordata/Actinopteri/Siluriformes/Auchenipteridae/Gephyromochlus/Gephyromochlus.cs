using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Gephyromochlus;

/// <summary>
/// Abstract class for Gephyromochlus (genus).
/// NCBI TaxId: 2613933
/// </summary>
public abstract class Gephyromochlus : Auchenipteridae, IGephyromochlus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gephyromochlus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2613933;

    /// <inheritdoc />
    public virtual string GenusName => "Gephyromochlus";

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
