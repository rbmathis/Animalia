using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Turdidae.Zoothera;

/// <summary>
/// Abstract class for Zoothera (genus).
/// NCBI TaxId: 36287
/// </summary>
public abstract class Zoothera : Turdidae, IZoothera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Zoothera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 36287;

    /// <inheritdoc />
    public virtual string GenusName => "Zoothera";

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
