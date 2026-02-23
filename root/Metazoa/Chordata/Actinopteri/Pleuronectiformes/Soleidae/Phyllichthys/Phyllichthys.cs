using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Soleidae.Phyllichthys;

/// <summary>
/// Abstract class for Phyllichthys (genus).
/// NCBI TaxId: 2755202
/// </summary>
public abstract class Phyllichthys : Soleidae, IPhyllichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phyllichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2755202;

    /// <inheritdoc />
    public virtual string GenusName => "Phyllichthys";

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
