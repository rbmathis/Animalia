using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae.Aphanius;

/// <summary>
/// Abstract class for Aphanius (genus).
/// NCBI TaxId: 30735
/// </summary>
public abstract class Aphanius : Aphaniidae, IAphanius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphanius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30735;

    /// <inheritdoc />
    public virtual string GenusName => "Aphanius";

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
