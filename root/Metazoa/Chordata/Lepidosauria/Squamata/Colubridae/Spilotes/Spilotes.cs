using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Spilotes;

/// <summary>
/// Abstract class for Spilotes (genus).
/// NCBI TaxId: 186603
/// </summary>
public abstract class Spilotes : Colubridae, ISpilotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spilotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 186603;

    /// <inheritdoc />
    public virtual string GenusName => "Spilotes";

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
