using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Cyclocoridae.Levitonius;

/// <summary>
/// Abstract class for Levitonius (genus).
/// NCBI TaxId: 2811534
/// </summary>
public abstract class Levitonius : Cyclocoridae, ILevitonius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Levitonius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2811534;

    /// <inheritdoc />
    public virtual string GenusName => "Levitonius";

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
