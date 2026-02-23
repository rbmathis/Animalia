using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Lebiasina;

/// <summary>
/// Abstract class for Lebiasina (genus).
/// NCBI TaxId: 270559
/// </summary>
public abstract class Lebiasina : Lebiasinidae, ILebiasina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lebiasina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 270559;

    /// <inheritdoc />
    public virtual string GenusName => "Lebiasina";

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
