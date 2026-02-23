using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Ovophis;

/// <summary>
/// Abstract class for Ovophis (genus).
/// NCBI TaxId: 42183
/// </summary>
public abstract class Ovophis : Viperidae, IOvophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ovophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42183;

    /// <inheritdoc />
    public virtual string GenusName => "Ovophis";

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
