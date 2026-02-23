using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Proatheris;

/// <summary>
/// Abstract class for Proatheris (genus).
/// NCBI TaxId: 110217
/// </summary>
public abstract class Proatheris : Viperidae, IProatheris
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Proatheris";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 110217;

    /// <inheritdoc />
    public virtual string GenusName => "Proatheris";

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
