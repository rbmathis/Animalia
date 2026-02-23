using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Calyptommatus;

/// <summary>
/// Abstract class for Calyptommatus (genus).
/// NCBI TaxId: 174741
/// </summary>
public abstract class Calyptommatus : Gymnophthalmidae, ICalyptommatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calyptommatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174741;

    /// <inheritdoc />
    public virtual string GenusName => "Calyptommatus";

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
