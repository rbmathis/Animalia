using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fluviphylacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Fluviphylacidae.Fluviphylax;

/// <summary>
/// Abstract class for Fluviphylax (genus).
/// NCBI TaxId: 28751
/// </summary>
public abstract class Fluviphylax : Fluviphylacidae, IFluviphylax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Fluviphylax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28751;

    /// <inheritdoc />
    public virtual string GenusName => "Fluviphylax";

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
