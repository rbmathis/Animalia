using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Coccotropsis;

/// <summary>
/// Abstract class for Coccotropsis (genus).
/// NCBI TaxId: 1311539
/// </summary>
public abstract class Coccotropsis : Tetrarogidae, ICoccotropsis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coccotropsis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1311539;

    /// <inheritdoc />
    public virtual string GenusName => "Coccotropsis";

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
