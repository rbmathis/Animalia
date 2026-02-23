using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Allophrynidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Allophrynidae.Allophryne;

/// <summary>
/// Abstract class for Allophryne (genus).
/// NCBI TaxId: 159189
/// </summary>
public abstract class Allophryne : Allophrynidae, IAllophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Allophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 159189;

    /// <inheritdoc />
    public virtual string GenusName => "Allophryne";

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
