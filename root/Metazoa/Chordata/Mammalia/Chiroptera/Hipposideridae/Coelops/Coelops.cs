using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Hipposideridae.Coelops;

/// <summary>
/// Abstract class for Coelops (genus).
/// NCBI TaxId: 187001
/// </summary>
public abstract class Coelops : Hipposideridae, ICoelops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coelops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187001;

    /// <inheritdoc />
    public virtual string GenusName => "Coelops";

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
