using AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Myxini.Myxiniformes.Myxinidae.Neomyxine;

/// <summary>
/// Abstract class for Neomyxine (genus).
/// NCBI TaxId: 1314860
/// </summary>
public abstract class Neomyxine : Myxinidae, INeomyxine
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neomyxine";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1314860;

    /// <inheritdoc />
    public virtual string GenusName => "Neomyxine";

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
