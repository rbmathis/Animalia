using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Moringuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Moringuidae.Neoconger;

/// <summary>
/// Abstract class for Neoconger (genus).
/// NCBI TaxId: 722441
/// </summary>
public abstract class Neoconger : Moringuidae, INeoconger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoconger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722441;

    /// <inheritdoc />
    public virtual string GenusName => "Neoconger";

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
