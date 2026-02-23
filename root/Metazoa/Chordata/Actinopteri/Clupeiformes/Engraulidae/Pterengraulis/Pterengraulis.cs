using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Pterengraulis;

/// <summary>
/// Abstract class for Pterengraulis (genus).
/// NCBI TaxId: 495046
/// </summary>
public abstract class Pterengraulis : Engraulidae, IPterengraulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pterengraulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495046;

    /// <inheritdoc />
    public virtual string GenusName => "Pterengraulis";

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
