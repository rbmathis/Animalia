using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Chiloconger;

/// <summary>
/// Abstract class for Chiloconger (genus).
/// NCBI TaxId: 3040444
/// </summary>
public abstract class Chiloconger : Congridae, IChiloconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chiloconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3040444;

    /// <inheritdoc />
    public virtual string GenusName => "Chiloconger";

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
