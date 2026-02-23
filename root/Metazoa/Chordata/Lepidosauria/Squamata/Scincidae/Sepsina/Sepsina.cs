using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sepsina;

/// <summary>
/// Abstract class for Sepsina (genus).
/// NCBI TaxId: 230630
/// </summary>
public abstract class Sepsina : Scincidae, ISepsina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sepsina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 230630;

    /// <inheritdoc />
    public virtual string GenusName => "Sepsina";

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
