using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rhinopristiformes.Rhinobatidae.Aptychotrema;

/// <summary>
/// Abstract class for Aptychotrema (genus).
/// NCBI TaxId: 117881
/// </summary>
public abstract class Aptychotrema : Rhinobatidae, IAptychotrema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aptychotrema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 117881;

    /// <inheritdoc />
    public virtual string GenusName => "Aptychotrema";

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
