using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Spinus;

/// <summary>
/// Abstract class for Spinus (genus).
/// NCBI TaxId: 1647189
/// </summary>
public abstract class Spinus : Fringillidae, ISpinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1647189;

    /// <inheritdoc />
    public virtual string GenusName => "Spinus";

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
