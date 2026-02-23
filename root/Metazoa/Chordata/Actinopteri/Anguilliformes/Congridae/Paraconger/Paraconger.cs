using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Paraconger;

/// <summary>
/// Abstract class for Paraconger (genus).
/// NCBI TaxId: 391199
/// </summary>
public abstract class Paraconger : Congridae, IParaconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 391199;

    /// <inheritdoc />
    public virtual string GenusName => "Paraconger";

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
