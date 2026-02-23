using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Sylviidae.Hylia;

/// <summary>
/// Abstract class for Hylia (genus).
/// NCBI TaxId: 208072
/// </summary>
public abstract class Hylia : Sylviidae, IHylia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hylia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 208072;

    /// <inheritdoc />
    public virtual string GenusName => "Hylia";

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
