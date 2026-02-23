using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Tetrarogidae.Snyderina;

/// <summary>
/// Abstract class for Snyderina (genus).
/// NCBI TaxId: 1414524
/// </summary>
public abstract class Snyderina : Tetrarogidae, ISnyderina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Snyderina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1414524;

    /// <inheritdoc />
    public virtual string GenusName => "Snyderina";

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
