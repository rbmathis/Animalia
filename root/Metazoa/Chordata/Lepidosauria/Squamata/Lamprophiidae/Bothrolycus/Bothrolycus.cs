using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Bothrolycus;

/// <summary>
/// Abstract class for Bothrolycus (genus).
/// NCBI TaxId: 292904
/// </summary>
public abstract class Bothrolycus : Lamprophiidae, IBothrolycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothrolycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 292904;

    /// <inheritdoc />
    public virtual string GenusName => "Bothrolycus";

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
