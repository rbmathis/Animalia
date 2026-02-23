using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Sistrurus;

/// <summary>
/// Abstract class for Sistrurus (genus).
/// NCBI TaxId: 8755
/// </summary>
public abstract class Sistrurus : Viperidae, ISistrurus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sistrurus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8755;

    /// <inheritdoc />
    public virtual string GenusName => "Sistrurus";

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
