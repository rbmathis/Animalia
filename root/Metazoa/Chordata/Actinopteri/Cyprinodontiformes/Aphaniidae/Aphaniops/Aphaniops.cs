using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Aphaniidae.Aphaniops;

/// <summary>
/// Abstract class for Aphaniops (genus).
/// NCBI TaxId: 2779316
/// </summary>
public abstract class Aphaniops : Aphaniidae, IAphaniops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aphaniops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2779316;

    /// <inheritdoc />
    public virtual string GenusName => "Aphaniops";

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
