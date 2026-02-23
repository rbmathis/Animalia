using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Tropidodipsas;

/// <summary>
/// Abstract class for Tropidodipsas (genus).
/// NCBI TaxId: 1212736
/// </summary>
public abstract class Tropidodipsas : Dipsadidae, ITropidodipsas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tropidodipsas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1212736;

    /// <inheritdoc />
    public virtual string GenusName => "Tropidodipsas";

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
