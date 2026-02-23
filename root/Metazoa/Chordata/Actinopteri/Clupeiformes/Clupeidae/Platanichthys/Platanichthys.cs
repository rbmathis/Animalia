using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Platanichthys;

/// <summary>
/// Abstract class for Platanichthys (genus).
/// NCBI TaxId: 864453
/// </summary>
public abstract class Platanichthys : Clupeidae, IPlatanichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platanichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 864453;

    /// <inheritdoc />
    public virtual string GenusName => "Platanichthys";

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
