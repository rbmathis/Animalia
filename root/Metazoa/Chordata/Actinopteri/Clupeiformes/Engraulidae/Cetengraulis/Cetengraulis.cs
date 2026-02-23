using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Cetengraulis;

/// <summary>
/// Abstract class for Cetengraulis (genus).
/// NCBI TaxId: 495042
/// </summary>
public abstract class Cetengraulis : Engraulidae, ICetengraulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cetengraulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495042;

    /// <inheritdoc />
    public virtual string GenusName => "Cetengraulis";

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
