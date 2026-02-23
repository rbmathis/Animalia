using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chalceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Chalceidae.Chalceus;

/// <summary>
/// Abstract class for Chalceus (genus).
/// NCBI TaxId: 42489
/// </summary>
public abstract class Chalceus : Chalceidae, IChalceus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chalceus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42489;

    /// <inheritdoc />
    public virtual string GenusName => "Chalceus";

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
