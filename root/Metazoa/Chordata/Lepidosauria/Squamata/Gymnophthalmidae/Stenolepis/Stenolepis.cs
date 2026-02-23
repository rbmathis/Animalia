using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gymnophthalmidae.Stenolepis;

/// <summary>
/// Abstract class for Stenolepis (genus).
/// NCBI TaxId: 174765
/// </summary>
public abstract class Stenolepis : Gymnophthalmidae, IStenolepis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Stenolepis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 174765;

    /// <inheritdoc />
    public virtual string GenusName => "Stenolepis";

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
