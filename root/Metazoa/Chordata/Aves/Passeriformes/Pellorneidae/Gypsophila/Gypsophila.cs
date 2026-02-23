using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Pellorneidae.Gypsophila;

/// <summary>
/// Abstract class for Gypsophila (genus).
/// NCBI TaxId: 2828480
/// </summary>
public abstract class Gypsophila : Pellorneidae, IGypsophila
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gypsophila";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2828480;

    /// <inheritdoc />
    public virtual string GenusName => "Gypsophila";

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
