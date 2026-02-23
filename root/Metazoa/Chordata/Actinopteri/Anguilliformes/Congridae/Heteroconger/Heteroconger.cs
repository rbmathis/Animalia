using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Heteroconger;

/// <summary>
/// Abstract class for Heteroconger (genus).
/// NCBI TaxId: 391205
/// </summary>
public abstract class Heteroconger : Congridae, IHeteroconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Heteroconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391205;

    /// <inheritdoc />
    public virtual string GenusName => "Heteroconger";

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
