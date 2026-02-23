using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Afronatrix;

/// <summary>
/// Abstract class for Afronatrix (genus).
/// NCBI TaxId: 173358
/// </summary>
public abstract class Afronatrix : Colubridae, IAfronatrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Afronatrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173358;

    /// <inheritdoc />
    public virtual string GenusName => "Afronatrix";

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
