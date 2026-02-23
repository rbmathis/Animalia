using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae.Esmaeilius;

/// <summary>
/// Abstract class for Esmaeilius (genus).
/// NCBI TaxId: 3363413
/// </summary>
public abstract class Esmaeilius : Aphaniidae, IEsmaeilius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Esmaeilius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363413;

    /// <inheritdoc />
    public virtual string GenusName => "Esmaeilius";

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
