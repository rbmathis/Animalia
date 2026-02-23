using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Haptenchelys;

/// <summary>
/// Abstract class for Haptenchelys (genus).
/// NCBI TaxId: 2768295
/// </summary>
public abstract class Haptenchelys : Synaphobranchidae, IHaptenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Haptenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2768295;

    /// <inheritdoc />
    public virtual string GenusName => "Haptenchelys";

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
