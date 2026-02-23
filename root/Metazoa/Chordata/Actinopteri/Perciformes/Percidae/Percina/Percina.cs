using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.Percina;

/// <summary>
/// Abstract class for Percina (genus).
/// NCBI TaxId: 54316
/// </summary>
public abstract class Percina : Percidae, IPercina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Percina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54316;

    /// <inheritdoc />
    public virtual string GenusName => "Percina";

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
