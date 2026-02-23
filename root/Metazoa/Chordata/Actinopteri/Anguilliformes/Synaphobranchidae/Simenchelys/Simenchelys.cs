using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Simenchelys;

/// <summary>
/// Abstract class for Simenchelys (genus).
/// NCBI TaxId: 189492
/// </summary>
public abstract class Simenchelys : Synaphobranchidae, ISimenchelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Simenchelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189492;

    /// <inheritdoc />
    public virtual string GenusName => "Simenchelys";

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
