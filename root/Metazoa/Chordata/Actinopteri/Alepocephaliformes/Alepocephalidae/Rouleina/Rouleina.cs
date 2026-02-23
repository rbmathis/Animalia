using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Alepocephaliformes.Alepocephalidae.Rouleina;

/// <summary>
/// Abstract class for Rouleina (genus).
/// NCBI TaxId: 700663
/// </summary>
public abstract class Rouleina : Alepocephalidae, IRouleina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rouleina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 700663;

    /// <inheritdoc />
    public virtual string GenusName => "Rouleina";

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
