using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Contia;

/// <summary>
/// Abstract class for Contia (genus).
/// NCBI TaxId: 158799
/// </summary>
public abstract class Contia : Dipsadidae, IContia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Contia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158799;

    /// <inheritdoc />
    public virtual string GenusName => "Contia";

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
