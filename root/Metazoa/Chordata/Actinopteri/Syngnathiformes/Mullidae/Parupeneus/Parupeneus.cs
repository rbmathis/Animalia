using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Parupeneus;

/// <summary>
/// Abstract class for Parupeneus (genus).
/// NCBI TaxId: 334899
/// </summary>
public abstract class Parupeneus : Mullidae, IParupeneus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Parupeneus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 334899;

    /// <inheritdoc />
    public virtual string GenusName => "Parupeneus";

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
