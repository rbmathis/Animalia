using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Chaetodermis;

/// <summary>
/// Abstract class for Chaetodermis (genus).
/// NCBI TaxId: 392912
/// </summary>
public abstract class Chaetodermis : Monacanthidae, IChaetodermis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetodermis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 392912;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetodermis";

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
