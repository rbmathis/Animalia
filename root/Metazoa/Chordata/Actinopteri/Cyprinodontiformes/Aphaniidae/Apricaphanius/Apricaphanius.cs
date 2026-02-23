using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae.Apricaphanius;

/// <summary>
/// Abstract class for Apricaphanius (genus).
/// NCBI TaxId: 3363386
/// </summary>
public abstract class Apricaphanius : Aphaniidae, IApricaphanius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Apricaphanius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363386;

    /// <inheritdoc />
    public virtual string GenusName => "Apricaphanius";

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
