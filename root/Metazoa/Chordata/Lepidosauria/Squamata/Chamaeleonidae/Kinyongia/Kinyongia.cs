using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Chamaeleonidae.Kinyongia;

/// <summary>
/// Abstract class for Kinyongia (genus).
/// NCBI TaxId: 414974
/// </summary>
public abstract class Kinyongia : Chamaeleonidae, IKinyongia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Kinyongia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 414974;

    /// <inheritdoc />
    public virtual string GenusName => "Kinyongia";

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
