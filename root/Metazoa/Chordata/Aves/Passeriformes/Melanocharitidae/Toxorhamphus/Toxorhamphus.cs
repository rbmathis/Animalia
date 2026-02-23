using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Melanocharitidae.Toxorhamphus;

/// <summary>
/// Abstract class for Toxorhamphus (genus).
/// NCBI TaxId: 175136
/// </summary>
public abstract class Toxorhamphus : Melanocharitidae, IToxorhamphus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Toxorhamphus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 175136;

    /// <inheritdoc />
    public virtual string GenusName => "Toxorhamphus";

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
