using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Leiothrichidae.Montecincla;

/// <summary>
/// Abstract class for Montecincla (genus).
/// NCBI TaxId: 1960640
/// </summary>
public abstract class Montecincla : Leiothrichidae, IMontecincla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Montecincla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1960640;

    /// <inheritdoc />
    public virtual string GenusName => "Montecincla";

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
