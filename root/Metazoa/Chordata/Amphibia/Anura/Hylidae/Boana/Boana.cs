using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Boana;

/// <summary>
/// Abstract class for Boana (genus).
/// NCBI TaxId: 2023954
/// </summary>
public abstract class Boana : Hylidae, IBoana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2023954;

    /// <inheritdoc />
    public virtual string GenusName => "Boana";

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
