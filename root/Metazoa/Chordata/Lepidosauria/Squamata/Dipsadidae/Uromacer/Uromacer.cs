using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Uromacer;

/// <summary>
/// Abstract class for Uromacer (genus).
/// NCBI TaxId: 121375
/// </summary>
public abstract class Uromacer : Dipsadidae, IUromacer
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uromacer";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121375;

    /// <inheritdoc />
    public virtual string GenusName => "Uromacer";

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
