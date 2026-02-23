using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Glandirana;

/// <summary>
/// Abstract class for Glandirana (genus).
/// NCBI TaxId: 167931
/// </summary>
public abstract class Glandirana : Ranidae, IGlandirana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Glandirana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 167931;

    /// <inheritdoc />
    public virtual string GenusName => "Glandirana";

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
