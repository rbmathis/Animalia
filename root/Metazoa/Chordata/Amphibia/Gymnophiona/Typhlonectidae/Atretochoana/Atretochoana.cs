using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Typhlonectidae.Atretochoana;

/// <summary>
/// Abstract class for Atretochoana (genus).
/// NCBI TaxId: 264005
/// </summary>
public abstract class Atretochoana : Typhlonectidae, IAtretochoana
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Atretochoana";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 264005;

    /// <inheritdoc />
    public virtual string GenusName => "Atretochoana";

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
