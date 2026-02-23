using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Dendrocincla;

/// <summary>
/// Abstract class for Dendrocincla (genus).
/// NCBI TaxId: 183178
/// </summary>
public abstract class Dendrocincla : Dendrocolaptidae, IDendrocincla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrocincla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183178;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrocincla";

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
