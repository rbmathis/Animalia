using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Siphonopidae.Microcaecilia;

/// <summary>
/// Abstract class for Microcaecilia (genus).
/// NCBI TaxId: 264009
/// </summary>
public abstract class Microcaecilia : Siphonopidae, IMicrocaecilia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microcaecilia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264009;

    /// <inheritdoc />
    public virtual string GenusName => "Microcaecilia";

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
