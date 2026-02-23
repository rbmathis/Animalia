using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phrynosomatidae.Phrynosoma;

/// <summary>
/// Abstract class for Phrynosoma (genus).
/// NCBI TaxId: 43608
/// </summary>
public abstract class Phrynosoma : Phrynosomatidae, IPhrynosoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phrynosoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 43608;

    /// <inheritdoc />
    public virtual string GenusName => "Phrynosoma";

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
