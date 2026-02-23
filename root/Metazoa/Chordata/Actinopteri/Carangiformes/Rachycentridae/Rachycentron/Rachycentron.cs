using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Rachycentridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Rachycentridae.Rachycentron;

/// <summary>
/// Abstract class for Rachycentron (genus).
/// NCBI TaxId: 141263
/// </summary>
public abstract class Rachycentron : Rachycentridae, IRachycentron
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rachycentron";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 141263;

    /// <inheritdoc />
    public virtual string GenusName => "Rachycentron";

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
