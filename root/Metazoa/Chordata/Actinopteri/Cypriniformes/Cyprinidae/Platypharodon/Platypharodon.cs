using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Platypharodon;

/// <summary>
/// Abstract class for Platypharodon (genus).
/// NCBI TaxId: 263518
/// </summary>
public abstract class Platypharodon : Cyprinidae, IPlatypharodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platypharodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 263518;

    /// <inheritdoc />
    public virtual string GenusName => "Platypharodon";

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
