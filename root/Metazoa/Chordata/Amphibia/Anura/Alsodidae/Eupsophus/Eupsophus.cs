using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Eupsophus;

/// <summary>
/// Abstract class for Eupsophus (genus).
/// NCBI TaxId: 209680
/// </summary>
public abstract class Eupsophus : Alsodidae, IEupsophus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eupsophus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 209680;

    /// <inheritdoc />
    public virtual string GenusName => "Eupsophus";

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
