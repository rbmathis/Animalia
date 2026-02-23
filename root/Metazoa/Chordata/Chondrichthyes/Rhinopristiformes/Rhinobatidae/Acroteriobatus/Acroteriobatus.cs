using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Acroteriobatus;

/// <summary>
/// Abstract class for Acroteriobatus (genus).
/// NCBI TaxId: 2578366
/// </summary>
public abstract class Acroteriobatus : Rhinobatidae, IAcroteriobatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acroteriobatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2578366;

    /// <inheritdoc />
    public virtual string GenusName => "Acroteriobatus";

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
