using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Macrovipera;

/// <summary>
/// Abstract class for Macrovipera (genus).
/// NCBI TaxId: 42187
/// </summary>
public abstract class Macrovipera : Viperidae, IMacrovipera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Macrovipera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42187;

    /// <inheritdoc />
    public virtual string GenusName => "Macrovipera";

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
