using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Enteromius;

/// <summary>
/// Abstract class for Enteromius (genus).
/// NCBI TaxId: 1911134
/// </summary>
public abstract class Enteromius : Cyprinidae, IEnteromius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Enteromius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1911134;

    /// <inheritdoc />
    public virtual string GenusName => "Enteromius";

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
