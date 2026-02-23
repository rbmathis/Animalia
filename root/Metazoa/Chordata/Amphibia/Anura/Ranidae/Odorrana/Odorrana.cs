using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Odorrana;

/// <summary>
/// Abstract class for Odorrana (genus).
/// NCBI TaxId: 121155
/// </summary>
public abstract class Odorrana : Ranidae, IOdorrana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odorrana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 121155;

    /// <inheritdoc />
    public virtual string GenusName => "Odorrana";

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
