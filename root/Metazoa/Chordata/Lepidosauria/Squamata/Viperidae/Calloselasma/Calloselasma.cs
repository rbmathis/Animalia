using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Calloselasma;

/// <summary>
/// Abstract class for Calloselasma (genus).
/// NCBI TaxId: 8774
/// </summary>
public abstract class Calloselasma : Viperidae, ICalloselasma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Calloselasma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8774;

    /// <inheritdoc />
    public virtual string GenusName => "Calloselasma";

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
