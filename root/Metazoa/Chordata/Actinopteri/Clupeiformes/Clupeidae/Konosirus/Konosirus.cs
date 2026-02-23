using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Konosirus;

/// <summary>
/// Abstract class for Konosirus (genus).
/// NCBI TaxId: 365055
/// </summary>
public abstract class Konosirus : Clupeidae, IKonosirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Konosirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 365055;

    /// <inheritdoc />
    public virtual string GenusName => "Konosirus";

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
