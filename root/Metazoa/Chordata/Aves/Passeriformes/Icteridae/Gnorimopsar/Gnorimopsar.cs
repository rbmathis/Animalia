using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Icteridae.Gnorimopsar;

/// <summary>
/// Abstract class for Gnorimopsar (genus).
/// NCBI TaxId: 84802
/// </summary>
public abstract class Gnorimopsar : Icteridae, IGnorimopsar
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gnorimopsar";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 84802;

    /// <inheritdoc />
    public virtual string GenusName => "Gnorimopsar";

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
