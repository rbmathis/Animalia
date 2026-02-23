using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Polyodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Polyodontidae.Polyodon;

/// <summary>
/// Abstract class for Polyodon (genus).
/// NCBI TaxId: 7912
/// </summary>
public abstract class Polyodon : Polyodontidae, IPolyodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polyodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7912;

    /// <inheritdoc />
    public virtual string GenusName => "Polyodon";

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
