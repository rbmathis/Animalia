using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Danionidae.Devario;

/// <summary>
/// Abstract class for Devario (genus).
/// NCBI TaxId: 439832
/// </summary>
public abstract class Devario : Danionidae, IDevario
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Devario";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 439832;

    /// <inheritdoc />
    public virtual string GenusName => "Devario";

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
