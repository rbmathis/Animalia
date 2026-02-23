using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Upeneus;

/// <summary>
/// Abstract class for Upeneus (genus).
/// NCBI TaxId: 115430
/// </summary>
public abstract class Upeneus : Mullidae, IUpeneus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Upeneus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115430;

    /// <inheritdoc />
    public virtual string GenusName => "Upeneus";

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
