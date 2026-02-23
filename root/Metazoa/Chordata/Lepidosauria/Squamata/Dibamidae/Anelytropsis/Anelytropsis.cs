using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dibamidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Dibamidae.Anelytropsis;

/// <summary>
/// Abstract class for Anelytropsis (genus).
/// NCBI TaxId: 405596
/// </summary>
public abstract class Anelytropsis : Dibamidae, IAnelytropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anelytropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 405596;

    /// <inheritdoc />
    public virtual string GenusName => "Anelytropsis";

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
