using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Medopheos;

/// <summary>
/// Abstract class for Medopheos (genus).
/// NCBI TaxId: 1447904
/// </summary>
public abstract class Medopheos : Teiidae, IMedopheos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Medopheos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1447904;

    /// <inheritdoc />
    public virtual string GenusName => "Medopheos";

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
