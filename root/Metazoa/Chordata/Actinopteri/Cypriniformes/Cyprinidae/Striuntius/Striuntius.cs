using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Striuntius;

/// <summary>
/// Abstract class for Striuntius (genus).
/// NCBI TaxId: 1606684
/// </summary>
public abstract class Striuntius : Cyprinidae, IStriuntius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Striuntius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1606684;

    /// <inheritdoc />
    public virtual string GenusName => "Striuntius";

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
