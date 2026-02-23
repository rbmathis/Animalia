using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Plethodontidae.Urspelerpes;

/// <summary>
/// Abstract class for Urspelerpes (genus).
/// NCBI TaxId: 698028
/// </summary>
public abstract class Urspelerpes : Plethodontidae, IUrspelerpes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Urspelerpes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 698028;

    /// <inheritdoc />
    public virtual string GenusName => "Urspelerpes";

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
