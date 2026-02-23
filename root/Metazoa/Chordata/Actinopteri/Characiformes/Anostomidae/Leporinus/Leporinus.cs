using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Leporinus;

/// <summary>
/// Abstract class for Leporinus (genus).
/// NCBI TaxId: 7987
/// </summary>
public abstract class Leporinus : Anostomidae, ILeporinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leporinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7987;

    /// <inheritdoc />
    public virtual string GenusName => "Leporinus";

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
