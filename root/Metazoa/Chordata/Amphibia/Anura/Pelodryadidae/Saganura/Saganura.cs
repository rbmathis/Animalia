using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Saganura;

/// <summary>
/// Abstract class for Saganura (genus).
/// NCBI TaxId: 3681006
/// </summary>
public abstract class Saganura : Pelodryadidae, ISaganura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Saganura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681006;

    /// <inheritdoc />
    public virtual string GenusName => "Saganura";

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
