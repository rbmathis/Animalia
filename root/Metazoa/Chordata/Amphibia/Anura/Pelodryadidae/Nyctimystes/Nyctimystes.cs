using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Nyctimystes;

/// <summary>
/// Abstract class for Nyctimystes (genus).
/// NCBI TaxId: 95142
/// </summary>
public abstract class Nyctimystes : Pelodryadidae, INyctimystes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctimystes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 95142;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctimystes";

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
