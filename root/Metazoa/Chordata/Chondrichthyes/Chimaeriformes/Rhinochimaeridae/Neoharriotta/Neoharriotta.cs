using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Rhinochimaeridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Chimaeriformes.Rhinochimaeridae.Neoharriotta;

/// <summary>
/// Abstract class for Neoharriotta (genus).
/// NCBI TaxId: 876123
/// </summary>
public abstract class Neoharriotta : Rhinochimaeridae, INeoharriotta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neoharriotta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 876123;

    /// <inheritdoc />
    public virtual string GenusName => "Neoharriotta";

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
