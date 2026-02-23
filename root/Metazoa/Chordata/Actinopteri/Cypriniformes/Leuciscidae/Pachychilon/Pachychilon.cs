using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pachychilon;

/// <summary>
/// Abstract class for Pachychilon (genus).
/// NCBI TaxId: 98645
/// </summary>
public abstract class Pachychilon : Leuciscidae, IPachychilon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pachychilon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 98645;

    /// <inheritdoc />
    public virtual string GenusName => "Pachychilon";

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
