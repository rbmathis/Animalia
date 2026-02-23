using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Hyalotos;

/// <summary>
/// Abstract class for Hyalotos (genus).
/// NCBI TaxId: 3680994
/// </summary>
public abstract class Hyalotos : Pelodryadidae, IHyalotos
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hyalotos";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680994;

    /// <inheritdoc />
    public virtual string GenusName => "Hyalotos";

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
