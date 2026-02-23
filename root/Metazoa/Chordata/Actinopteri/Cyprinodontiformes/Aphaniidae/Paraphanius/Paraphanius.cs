using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae.Paraphanius;

/// <summary>
/// Abstract class for Paraphanius (genus).
/// NCBI TaxId: 2901412
/// </summary>
public abstract class Paraphanius : Aphaniidae, IParaphanius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paraphanius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2901412;

    /// <inheritdoc />
    public virtual string GenusName => "Paraphanius";

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
