using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pempheriformes.Percophidae.Acanthaphritis;

/// <summary>
/// Abstract class for Acanthaphritis (genus).
/// NCBI TaxId: 270606
/// </summary>
public abstract class Acanthaphritis : Percophidae, IAcanthaphritis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthaphritis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270606;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthaphritis";

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
