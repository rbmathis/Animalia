using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Zingel;

/// <summary>
/// Abstract class for Zingel (genus).
/// NCBI TaxId: 77141
/// </summary>
public abstract class Zingel : Percidae, IZingel
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zingel";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 77141;

    /// <inheritdoc />
    public virtual string GenusName => "Zingel";

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
