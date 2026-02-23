using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Pseudupeneus;

/// <summary>
/// Abstract class for Pseudupeneus (genus).
/// NCBI TaxId: 115428
/// </summary>
public abstract class Pseudupeneus : Mullidae, IPseudupeneus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudupeneus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115428;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudupeneus";

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
