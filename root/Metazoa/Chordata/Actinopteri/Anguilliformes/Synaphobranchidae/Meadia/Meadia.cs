using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.Meadia;

/// <summary>
/// Abstract class for Meadia (genus).
/// NCBI TaxId: 189488
/// </summary>
public abstract class Meadia : Synaphobranchidae, IMeadia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Meadia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 189488;

    /// <inheritdoc />
    public virtual string GenusName => "Meadia";

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
