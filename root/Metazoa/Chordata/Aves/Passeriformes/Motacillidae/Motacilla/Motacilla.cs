using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Motacillidae.Motacilla;

/// <summary>
/// Abstract class for Motacilla (genus).
/// NCBI TaxId: 45806
/// </summary>
public abstract class Motacilla : Motacillidae, IMotacilla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Motacilla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 45806;

    /// <inheritdoc />
    public virtual string GenusName => "Motacilla";

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
