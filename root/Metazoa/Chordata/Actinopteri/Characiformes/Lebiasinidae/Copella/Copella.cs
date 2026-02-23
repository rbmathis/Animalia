using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Lebiasinidae.Copella;

/// <summary>
/// Abstract class for Copella (genus).
/// NCBI TaxId: 930311
/// </summary>
public abstract class Copella : Lebiasinidae, ICopella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Copella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930311;

    /// <inheritdoc />
    public virtual string GenusName => "Copella";

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
