using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Pareatidae.Pareas;

/// <summary>
/// Abstract class for Pareas (genus).
/// NCBI TaxId: 46308
/// </summary>
public abstract class Pareas : Pareatidae, IPareas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pareas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 46308;

    /// <inheritdoc />
    public virtual string GenusName => "Pareas";

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
