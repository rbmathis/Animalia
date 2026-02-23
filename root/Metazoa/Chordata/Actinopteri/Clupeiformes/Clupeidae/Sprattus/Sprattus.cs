using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Sprattus;

/// <summary>
/// Abstract class for Sprattus (genus).
/// NCBI TaxId: 196074
/// </summary>
public abstract class Sprattus : Clupeidae, ISprattus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sprattus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 196074;

    /// <inheritdoc />
    public virtual string GenusName => "Sprattus";

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
