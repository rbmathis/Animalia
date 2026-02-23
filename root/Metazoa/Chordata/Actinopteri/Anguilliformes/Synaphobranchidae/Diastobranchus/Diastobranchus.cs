using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Diastobranchus;

/// <summary>
/// Abstract class for Diastobranchus (genus).
/// NCBI TaxId: 443777
/// </summary>
public abstract class Diastobranchus : Synaphobranchidae, IDiastobranchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Diastobranchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 443777;

    /// <inheritdoc />
    public virtual string GenusName => "Diastobranchus";

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
