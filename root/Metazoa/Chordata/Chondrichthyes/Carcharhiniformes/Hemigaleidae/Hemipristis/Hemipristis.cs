using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae.Hemipristis;

/// <summary>
/// Abstract class for Hemipristis (genus).
/// NCBI TaxId: 496089
/// </summary>
public abstract class Hemipristis : Hemigaleidae, IHemipristis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hemipristis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 496089;

    /// <inheritdoc />
    public virtual string GenusName => "Hemipristis";

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
