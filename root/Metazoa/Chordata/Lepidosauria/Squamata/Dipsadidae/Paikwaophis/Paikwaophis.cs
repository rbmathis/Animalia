using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dipsadidae.Paikwaophis;

/// <summary>
/// Abstract class for Paikwaophis (genus).
/// NCBI TaxId: 3070694
/// </summary>
public abstract class Paikwaophis : Dipsadidae, IPaikwaophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paikwaophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3070694;

    /// <inheritdoc />
    public virtual string GenusName => "Paikwaophis";

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
