using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acropomatiformes.Creediidae.Myopsaron;

/// <summary>
/// Abstract class for Myopsaron (genus).
/// NCBI TaxId: 1633519
/// </summary>
public abstract class Myopsaron : Creediidae, IMyopsaron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myopsaron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1633519;

    /// <inheritdoc />
    public virtual string GenusName => "Myopsaron";

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
