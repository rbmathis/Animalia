using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Bathymyrus;

/// <summary>
/// Abstract class for Bathymyrus (genus).
/// NCBI TaxId: 2650381
/// </summary>
public abstract class Bathymyrus : Congridae, IBathymyrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bathymyrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2650381;

    /// <inheritdoc />
    public virtual string GenusName => "Bathymyrus";

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
