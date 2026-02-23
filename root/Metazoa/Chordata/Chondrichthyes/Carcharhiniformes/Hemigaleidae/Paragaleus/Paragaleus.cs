using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae.Paragaleus;

/// <summary>
/// Abstract class for Paragaleus (genus).
/// NCBI TaxId: 1073564
/// </summary>
public abstract class Paragaleus : Hemigaleidae, IParagaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paragaleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1073564;

    /// <inheritdoc />
    public virtual string GenusName => "Paragaleus";

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
