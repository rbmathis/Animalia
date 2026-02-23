using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Gallotia;

/// <summary>
/// Abstract class for Gallotia (genus).
/// NCBI TaxId: 39189
/// </summary>
public abstract class Gallotia : Lacertidae, IGallotia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gallotia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 39189;

    /// <inheritdoc />
    public virtual string GenusName => "Gallotia";

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
