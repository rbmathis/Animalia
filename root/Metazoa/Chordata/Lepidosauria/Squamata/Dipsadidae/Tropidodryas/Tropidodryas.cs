using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tropidodryas;

/// <summary>
/// Abstract class for Tropidodryas (genus).
/// NCBI TaxId: 120311
/// </summary>
public abstract class Tropidodryas : Dipsadidae, ITropidodryas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropidodryas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 120311;

    /// <inheritdoc />
    public virtual string GenusName => "Tropidodryas";

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
