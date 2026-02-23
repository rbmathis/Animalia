using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Talpidae.Desmana;

/// <summary>
/// Abstract class for Desmana (genus).
/// NCBI TaxId: 182681
/// </summary>
public abstract class Desmana : Talpidae, IDesmana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Desmana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 182681;

    /// <inheritdoc />
    public virtual string GenusName => "Desmana";

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
