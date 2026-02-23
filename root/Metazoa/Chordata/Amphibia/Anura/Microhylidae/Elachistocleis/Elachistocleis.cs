using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Microhylidae.Elachistocleis;

/// <summary>
/// Abstract class for Elachistocleis (genus).
/// NCBI TaxId: 143566
/// </summary>
public abstract class Elachistocleis : Microhylidae, IElachistocleis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elachistocleis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 143566;

    /// <inheritdoc />
    public virtual string GenusName => "Elachistocleis";

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
