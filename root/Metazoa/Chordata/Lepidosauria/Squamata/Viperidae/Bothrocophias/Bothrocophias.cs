using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Viperidae.Bothrocophias;

/// <summary>
/// Abstract class for Bothrocophias (genus).
/// NCBI TaxId: 230467
/// </summary>
public abstract class Bothrocophias : Viperidae, IBothrocophias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bothrocophias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 230467;

    /// <inheritdoc />
    public virtual string GenusName => "Bothrocophias";

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
