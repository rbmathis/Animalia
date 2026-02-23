using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Drymotoxeres;

/// <summary>
/// Abstract class for Drymotoxeres (genus).
/// NCBI TaxId: 2821312
/// </summary>
public abstract class Drymotoxeres : Dendrocolaptidae, IDrymotoxeres
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Drymotoxeres";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821312;

    /// <inheritdoc />
    public virtual string GenusName => "Drymotoxeres";

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
