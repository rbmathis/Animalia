using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Farancia;

/// <summary>
/// Abstract class for Farancia (genus).
/// NCBI TaxId: 39146
/// </summary>
public abstract class Farancia : Dipsadidae, IFarancia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Farancia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39146;

    /// <inheritdoc />
    public virtual string GenusName => "Farancia";

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
