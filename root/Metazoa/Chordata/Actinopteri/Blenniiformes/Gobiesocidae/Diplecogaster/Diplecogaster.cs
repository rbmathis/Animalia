using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Gobiesocidae.Diplecogaster;

/// <summary>
/// Abstract class for Diplecogaster (genus).
/// NCBI TaxId: 210028
/// </summary>
public abstract class Diplecogaster : Gobiesocidae, IDiplecogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diplecogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 210028;

    /// <inheritdoc />
    public virtual string GenusName => "Diplecogaster";

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
