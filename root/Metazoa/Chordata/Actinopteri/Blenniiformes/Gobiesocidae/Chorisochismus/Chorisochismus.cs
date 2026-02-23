using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Chorisochismus;

/// <summary>
/// Abstract class for Chorisochismus (genus).
/// NCBI TaxId: 990973
/// </summary>
public abstract class Chorisochismus : Gobiesocidae, IChorisochismus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chorisochismus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 990973;

    /// <inheritdoc />
    public virtual string GenusName => "Chorisochismus";

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
