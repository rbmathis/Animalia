using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Laniellus;

/// <summary>
/// Abstract class for Laniellus (genus).
/// NCBI TaxId: 2183794
/// </summary>
public abstract class Laniellus : Leiothrichidae, ILaniellus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Laniellus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2183794;

    /// <inheritdoc />
    public virtual string GenusName => "Laniellus";

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
