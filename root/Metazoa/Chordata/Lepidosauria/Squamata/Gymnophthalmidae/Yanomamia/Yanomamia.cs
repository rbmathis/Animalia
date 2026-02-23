using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Yanomamia;

/// <summary>
/// Abstract class for Yanomamia (genus).
/// NCBI TaxId: 2571430
/// </summary>
public abstract class Yanomamia : Gymnophthalmidae, IYanomamia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Yanomamia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2571430;

    /// <inheritdoc />
    public virtual string GenusName => "Yanomamia";

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
