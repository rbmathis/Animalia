using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Aspasmogaster;

/// <summary>
/// Abstract class for Aspasmogaster (genus).
/// NCBI TaxId: 1986068
/// </summary>
public abstract class Aspasmogaster : Gobiesocidae, IAspasmogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspasmogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1986068;

    /// <inheritdoc />
    public virtual string GenusName => "Aspasmogaster";

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
