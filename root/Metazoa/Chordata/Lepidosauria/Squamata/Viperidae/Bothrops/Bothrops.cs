using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Bothrops;

/// <summary>
/// Abstract class for Bothrops (genus).
/// NCBI TaxId: 8721
/// </summary>
public abstract class Bothrops : Viperidae, IBothrops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothrops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8721;

    /// <inheritdoc />
    public virtual string GenusName => "Bothrops";

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
