using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Orectolobiformes.Orectolobidae.Eucrossorhinus;

/// <summary>
/// Abstract class for Eucrossorhinus (genus).
/// NCBI TaxId: 582435
/// </summary>
public abstract class Eucrossorhinus : Orectolobidae, IEucrossorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eucrossorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 582435;

    /// <inheritdoc />
    public virtual string GenusName => "Eucrossorhinus";

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
