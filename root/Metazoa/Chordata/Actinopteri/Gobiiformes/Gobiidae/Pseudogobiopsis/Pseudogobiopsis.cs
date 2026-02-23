using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Pseudogobiopsis;

/// <summary>
/// Abstract class for Pseudogobiopsis (genus).
/// NCBI TaxId: 1873367
/// </summary>
public abstract class Pseudogobiopsis : Gobiidae, IPseudogobiopsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudogobiopsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1873367;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudogobiopsis";

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
