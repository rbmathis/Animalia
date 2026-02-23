using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Cairina;

/// <summary>
/// Abstract class for Cairina (genus).
/// NCBI TaxId: 8854
/// </summary>
public abstract class Cairina : Anatidae, ICairina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cairina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8854;

    /// <inheritdoc />
    public virtual string GenusName => "Cairina";

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
