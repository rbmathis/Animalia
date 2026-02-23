using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Niltava;

/// <summary>
/// Abstract class for Niltava (genus).
/// NCBI TaxId: 427696
/// </summary>
public abstract class Niltava : Muscicapidae, INiltava
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Niltava";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 427696;

    /// <inheritdoc />
    public virtual string GenusName => "Niltava";

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
