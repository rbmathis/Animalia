using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Poyntonia;

/// <summary>
/// Abstract class for Poyntonia (genus).
/// NCBI TaxId: 333698
/// </summary>
public abstract class Poyntonia : Pyxicephalidae, IPoyntonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Poyntonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 333698;

    /// <inheritdoc />
    public virtual string GenusName => "Poyntonia";

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
