using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.Chelon;

/// <summary>
/// Abstract class for Chelon (genus).
/// NCBI TaxId: 48170
/// </summary>
public abstract class Chelon : Mugilidae, IChelon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chelon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 48170;

    /// <inheritdoc />
    public virtual string GenusName => "Chelon";

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
