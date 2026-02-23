using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Porthidium;

/// <summary>
/// Abstract class for Porthidium (genus).
/// NCBI TaxId: 44715
/// </summary>
public abstract class Porthidium : Viperidae, IPorthidium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porthidium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44715;

    /// <inheritdoc />
    public virtual string GenusName => "Porthidium";

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
