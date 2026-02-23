using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Anacanthobatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Rajiformes.Anacanthobatidae.Sinobatis;

/// <summary>
/// Abstract class for Sinobatis (genus).
/// NCBI TaxId: 1072511
/// </summary>
public abstract class Sinobatis : Anacanthobatidae, ISinobatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sinobatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1072511;

    /// <inheritdoc />
    public virtual string GenusName => "Sinobatis";

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
