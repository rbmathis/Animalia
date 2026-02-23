using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Azemiops;

/// <summary>
/// Abstract class for Azemiops (genus).
/// NCBI TaxId: 8772
/// </summary>
public abstract class Azemiops : Viperidae, IAzemiops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Azemiops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8772;

    /// <inheritdoc />
    public virtual string GenusName => "Azemiops";

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
