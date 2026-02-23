using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Dendrocolaptidae.Dendroplex;

/// <summary>
/// Abstract class for Dendroplex (genus).
/// NCBI TaxId: 2821480
/// </summary>
public abstract class Dendroplex : Dendrocolaptidae, IDendroplex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendroplex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821480;

    /// <inheritdoc />
    public virtual string GenusName => "Dendroplex";

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
