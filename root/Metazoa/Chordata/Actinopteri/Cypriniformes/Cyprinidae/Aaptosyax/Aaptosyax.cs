using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Aaptosyax;

/// <summary>
/// Abstract class for Aaptosyax (genus).
/// NCBI TaxId: 143609
/// </summary>
public abstract class Aaptosyax : Cyprinidae, IAaptosyax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aaptosyax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143609;

    /// <inheritdoc />
    public virtual string GenusName => "Aaptosyax";

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
