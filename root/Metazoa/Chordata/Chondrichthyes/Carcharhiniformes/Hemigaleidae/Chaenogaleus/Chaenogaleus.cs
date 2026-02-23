using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Hemigaleidae.Chaenogaleus;

/// <summary>
/// Abstract class for Chaenogaleus (genus).
/// NCBI TaxId: 376644
/// </summary>
public abstract class Chaenogaleus : Hemigaleidae, IChaenogaleus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaenogaleus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 376644;

    /// <inheritdoc />
    public virtual string GenusName => "Chaenogaleus";

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
