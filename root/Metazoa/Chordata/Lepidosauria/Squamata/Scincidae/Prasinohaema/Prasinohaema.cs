using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Prasinohaema;

/// <summary>
/// Abstract class for Prasinohaema (genus).
/// NCBI TaxId: 220791
/// </summary>
public abstract class Prasinohaema : Scincidae, IPrasinohaema
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prasinohaema";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 220791;

    /// <inheritdoc />
    public virtual string GenusName => "Prasinohaema";

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
