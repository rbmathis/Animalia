using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Dipsas;

/// <summary>
/// Abstract class for Dipsas (genus).
/// NCBI TaxId: 39144
/// </summary>
public abstract class Dipsas : Dipsadidae, IDipsas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dipsas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39144;

    /// <inheritdoc />
    public virtual string GenusName => "Dipsas";

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
