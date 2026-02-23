using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Causus;

/// <summary>
/// Abstract class for Causus (genus).
/// NCBI TaxId: 44734
/// </summary>
public abstract class Causus : Viperidae, ICausus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Causus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44734;

    /// <inheritdoc />
    public virtual string GenusName => "Causus";

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
