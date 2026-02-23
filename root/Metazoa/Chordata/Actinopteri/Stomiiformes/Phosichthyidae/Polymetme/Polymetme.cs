using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Stomiiformes.Phosichthyidae.Polymetme;

/// <summary>
/// Abstract class for Polymetme (genus).
/// NCBI TaxId: 700659
/// </summary>
public abstract class Polymetme : Phosichthyidae, IPolymetme
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polymetme";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 700659;

    /// <inheritdoc />
    public virtual string GenusName => "Polymetme";

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
