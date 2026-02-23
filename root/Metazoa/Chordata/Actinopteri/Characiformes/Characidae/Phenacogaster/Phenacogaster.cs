using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Phenacogaster;

/// <summary>
/// Abstract class for Phenacogaster (genus).
/// NCBI TaxId: 681927
/// </summary>
public abstract class Phenacogaster : Characidae, IPhenacogaster
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phenacogaster";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 681927;

    /// <inheritdoc />
    public virtual string GenusName => "Phenacogaster";

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
