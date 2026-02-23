using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Scyliorhinidae.Cephaloscyllium;

/// <summary>
/// Abstract class for Cephaloscyllium (genus).
/// NCBI TaxId: 232418
/// </summary>
public abstract class Cephaloscyllium : Scyliorhinidae, ICephaloscyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cephaloscyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 232418;

    /// <inheritdoc />
    public virtual string GenusName => "Cephaloscyllium";

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
