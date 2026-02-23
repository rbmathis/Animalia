using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Mimophis;

/// <summary>
/// Abstract class for Mimophis (genus).
/// NCBI TaxId: 143665
/// </summary>
public abstract class Mimophis : Lamprophiidae, IMimophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mimophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143665;

    /// <inheritdoc />
    public virtual string GenusName => "Mimophis";

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
