using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Pseudoficimia;

/// <summary>
/// Abstract class for Pseudoficimia (genus).
/// NCBI TaxId: 699592
/// </summary>
public abstract class Pseudoficimia : Colubridae, IPseudoficimia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoficimia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 699592;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoficimia";

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
