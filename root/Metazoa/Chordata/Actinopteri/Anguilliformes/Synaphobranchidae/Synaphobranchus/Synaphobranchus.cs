using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Synaphobranchus;

/// <summary>
/// Abstract class for Synaphobranchus (genus).
/// NCBI TaxId: 118153
/// </summary>
public abstract class Synaphobranchus : Synaphobranchidae, ISynaphobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Synaphobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 118153;

    /// <inheritdoc />
    public virtual string GenusName => "Synaphobranchus";

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
