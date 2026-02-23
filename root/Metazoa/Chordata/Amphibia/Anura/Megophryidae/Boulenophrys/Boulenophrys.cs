using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Megophryidae.Boulenophrys;

/// <summary>
/// Abstract class for Boulenophrys (genus).
/// NCBI TaxId: 2923548
/// </summary>
public abstract class Boulenophrys : Megophryidae, IBoulenophrys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Boulenophrys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2923548;

    /// <inheritdoc />
    public virtual string GenusName => "Boulenophrys";

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
