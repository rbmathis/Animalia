using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Zeiformes.Zenionidae.Cyttomimus;

/// <summary>
/// Abstract class for Cyttomimus (genus).
/// NCBI TaxId: 1367217
/// </summary>
public abstract class Cyttomimus : Zenionidae, ICyttomimus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cyttomimus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1367217;

    /// <inheritdoc />
    public virtual string GenusName => "Cyttomimus";

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
