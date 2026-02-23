using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Rhombosoleidae.Rhombosolea;

/// <summary>
/// Abstract class for Rhombosolea (genus).
/// NCBI TaxId: 443809
/// </summary>
public abstract class Rhombosolea : Rhombosoleidae, IRhombosolea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhombosolea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443809;

    /// <inheritdoc />
    public virtual string GenusName => "Rhombosolea";

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
