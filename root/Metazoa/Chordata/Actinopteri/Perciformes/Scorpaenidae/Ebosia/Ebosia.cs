using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Ebosia;

/// <summary>
/// Abstract class for Ebosia (genus).
/// NCBI TaxId: 1306750
/// </summary>
public abstract class Ebosia : Scorpaenidae, IEbosia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ebosia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1306750;

    /// <inheritdoc />
    public virtual string GenusName => "Ebosia";

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
