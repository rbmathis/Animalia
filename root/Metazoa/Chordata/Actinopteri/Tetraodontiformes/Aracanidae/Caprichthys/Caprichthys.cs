using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Aracanidae.Caprichthys;

/// <summary>
/// Abstract class for Caprichthys (genus).
/// NCBI TaxId: 1240565
/// </summary>
public abstract class Caprichthys : Aracanidae, ICaprichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Caprichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1240565;

    /// <inheritdoc />
    public virtual string GenusName => "Caprichthys";

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
