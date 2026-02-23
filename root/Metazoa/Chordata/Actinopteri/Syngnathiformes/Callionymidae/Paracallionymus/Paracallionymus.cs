using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Callionymidae.Paracallionymus;

/// <summary>
/// Abstract class for Paracallionymus (genus).
/// NCBI TaxId: 1003975
/// </summary>
public abstract class Paracallionymus : Callionymidae, IParacallionymus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paracallionymus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1003975;

    /// <inheritdoc />
    public virtual string GenusName => "Paracallionymus";

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
