using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Aphyonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ophidiiformes.Aphyonidae.Barathronus;

/// <summary>
/// Abstract class for Barathronus (genus).
/// NCBI TaxId: 1367208
/// </summary>
public abstract class Barathronus : Aphyonidae, IBarathronus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Barathronus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1367208;

    /// <inheritdoc />
    public virtual string GenusName => "Barathronus";

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
