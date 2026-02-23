using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Ischnohyla;

/// <summary>
/// Abstract class for Ischnohyla (genus).
/// NCBI TaxId: 3680995
/// </summary>
public abstract class Ischnohyla : Pelodryadidae, IIschnohyla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ischnohyla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3680995;

    /// <inheritdoc />
    public virtual string GenusName => "Ischnohyla";

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
