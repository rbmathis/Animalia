using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Engraulis;

/// <summary>
/// Abstract class for Engraulis (genus).
/// NCBI TaxId: 42891
/// </summary>
public abstract class Engraulis : Engraulidae, IEngraulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Engraulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 42891;

    /// <inheritdoc />
    public virtual string GenusName => "Engraulis";

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
