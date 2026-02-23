using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Megaleporinus;

/// <summary>
/// Abstract class for Megaleporinus (genus).
/// NCBI TaxId: 1925018
/// </summary>
public abstract class Megaleporinus : Anostomidae, IMegaleporinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Megaleporinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1925018;

    /// <inheritdoc />
    public virtual string GenusName => "Megaleporinus";

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
