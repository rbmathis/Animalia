using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Ophichthidae.Pseudomyrophis;

/// <summary>
/// Abstract class for Pseudomyrophis (genus).
/// NCBI TaxId: 722522
/// </summary>
public abstract class Pseudomyrophis : Ophichthidae, IPseudomyrophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudomyrophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722522;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudomyrophis";

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
