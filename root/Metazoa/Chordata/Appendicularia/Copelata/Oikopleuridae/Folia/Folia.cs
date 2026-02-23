using AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.Copelata.Oikopleuridae.Folia;

/// <summary>
/// Abstract class for Folia (genus).
/// NCBI TaxId: 2547640
/// </summary>
public abstract class Folia : Oikopleuridae, IFolia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Folia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2547640;

    /// <inheritdoc />
    public virtual string GenusName => "Folia";

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
