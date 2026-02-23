using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Acanthisittidae.Pachyplichas;

/// <summary>
/// Abstract class for Pachyplichas (genus).
/// NCBI TaxId: 1860149
/// </summary>
public abstract class Pachyplichas : Acanthisittidae, IPachyplichas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachyplichas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1860149;

    /// <inheritdoc />
    public virtual string GenusName => "Pachyplichas";

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
