using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Ianthocincla;

/// <summary>
/// Abstract class for Ianthocincla (genus).
/// NCBI TaxId: 2698657
/// </summary>
public abstract class Ianthocincla : Leiothrichidae, IIanthocincla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ianthocincla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2698657;

    /// <inheritdoc />
    public virtual string GenusName => "Ianthocincla";

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
