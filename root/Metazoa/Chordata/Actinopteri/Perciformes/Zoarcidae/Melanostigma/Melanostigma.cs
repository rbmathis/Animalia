using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Zoarcidae.Melanostigma;

/// <summary>
/// Abstract class for Melanostigma (genus).
/// NCBI TaxId: 557411
/// </summary>
public abstract class Melanostigma : Zoarcidae, IMelanostigma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanostigma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 557411;

    /// <inheritdoc />
    public virtual string GenusName => "Melanostigma";

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
