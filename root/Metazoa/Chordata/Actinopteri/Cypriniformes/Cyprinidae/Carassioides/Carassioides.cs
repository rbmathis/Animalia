using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Carassioides;

/// <summary>
/// Abstract class for Carassioides (genus).
/// NCBI TaxId: 381626
/// </summary>
public abstract class Carassioides : Cyprinidae, ICarassioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carassioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 381626;

    /// <inheritdoc />
    public virtual string GenusName => "Carassioides";

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
