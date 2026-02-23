using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Plesiodipsas;

/// <summary>
/// Abstract class for Plesiodipsas (genus).
/// NCBI TaxId: 1545385
/// </summary>
public abstract class Plesiodipsas : Dipsadidae, IPlesiodipsas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Plesiodipsas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1545385;

    /// <inheritdoc />
    public virtual string GenusName => "Plesiodipsas";

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
