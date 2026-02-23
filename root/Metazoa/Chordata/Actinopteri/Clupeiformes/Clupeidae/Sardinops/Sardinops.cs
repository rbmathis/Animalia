using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sardinops;

/// <summary>
/// Abstract class for Sardinops (genus).
/// NCBI TaxId: 28380
/// </summary>
public abstract class Sardinops : Clupeidae, ISardinops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sardinops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28380;

    /// <inheritdoc />
    public virtual string GenusName => "Sardinops";

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
