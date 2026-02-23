using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Echis;

/// <summary>
/// Abstract class for Echis (genus).
/// NCBI TaxId: 8699
/// </summary>
public abstract class Echis : Viperidae, IEchis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8699;

    /// <inheritdoc />
    public virtual string GenusName => "Echis";

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
