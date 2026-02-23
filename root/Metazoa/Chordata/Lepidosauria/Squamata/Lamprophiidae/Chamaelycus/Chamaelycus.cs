using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lamprophiidae.Chamaelycus;

/// <summary>
/// Abstract class for Chamaelycus (genus).
/// NCBI TaxId: 1419186
/// </summary>
public abstract class Chamaelycus : Lamprophiidae, IChamaelycus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chamaelycus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1419186;

    /// <inheritdoc />
    public virtual string GenusName => "Chamaelycus";

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
