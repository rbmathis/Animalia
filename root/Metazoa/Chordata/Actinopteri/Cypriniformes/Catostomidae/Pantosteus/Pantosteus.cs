using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Pantosteus;

/// <summary>
/// Abstract class for Pantosteus (genus).
/// NCBI TaxId: 3411133
/// </summary>
public abstract class Pantosteus : Catostomidae, IPantosteus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pantosteus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3411133;

    /// <inheritdoc />
    public virtual string GenusName => "Pantosteus";

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
