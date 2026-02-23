using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Cynops;

/// <summary>
/// Abstract class for Cynops (genus).
/// NCBI TaxId: 8329
/// </summary>
public abstract class Cynops : Salamandridae, ICynops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cynops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8329;

    /// <inheritdoc />
    public virtual string GenusName => "Cynops";

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
