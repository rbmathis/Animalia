using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Abavorana;

/// <summary>
/// Abstract class for Abavorana (genus).
/// NCBI TaxId: 1659749
/// </summary>
public abstract class Abavorana : Ranidae, IAbavorana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Abavorana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1659749;

    /// <inheritdoc />
    public virtual string GenusName => "Abavorana";

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
