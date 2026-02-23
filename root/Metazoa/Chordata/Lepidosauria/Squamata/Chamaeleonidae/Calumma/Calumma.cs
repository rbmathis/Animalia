using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Calumma;

/// <summary>
/// Abstract class for Calumma (genus).
/// NCBI TaxId: 143467
/// </summary>
public abstract class Calumma : Chamaeleonidae, ICalumma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calumma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143467;

    /// <inheritdoc />
    public virtual string GenusName => "Calumma";

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
