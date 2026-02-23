using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Chlamydoselachidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Hexanchiformes.Chlamydoselachidae.Chlamydoselachus;

/// <summary>
/// Abstract class for Chlamydoselachus (genus).
/// NCBI TaxId: 27584
/// </summary>
public abstract class Chlamydoselachus : Chlamydoselachidae, IChlamydoselachus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlamydoselachus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27584;

    /// <inheritdoc />
    public virtual string GenusName => "Chlamydoselachus";

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
