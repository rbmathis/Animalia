using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Ovalentaria_incertae_sedis.Plesiopidae.Assessor;

/// <summary>
/// Abstract class for Assessor (genus).
/// NCBI TaxId: 546542
/// </summary>
public abstract class Assessor : Plesiopidae, IAssessor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Assessor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 546542;

    /// <inheritdoc />
    public virtual string GenusName => "Assessor";

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
