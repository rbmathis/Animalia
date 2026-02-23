using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Leporellus;

/// <summary>
/// Abstract class for Leporellus (genus).
/// NCBI TaxId: 1123871
/// </summary>
public abstract class Leporellus : Anostomidae, ILeporellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leporellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1123871;

    /// <inheritdoc />
    public virtual string GenusName => "Leporellus";

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
