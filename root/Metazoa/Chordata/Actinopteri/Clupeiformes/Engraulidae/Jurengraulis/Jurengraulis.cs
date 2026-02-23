using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Jurengraulis;

/// <summary>
/// Abstract class for Jurengraulis (genus).
/// NCBI TaxId: 495045
/// </summary>
public abstract class Jurengraulis : Engraulidae, IJurengraulis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Jurengraulis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 495045;

    /// <inheritdoc />
    public virtual string GenusName => "Jurengraulis";

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
