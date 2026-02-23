using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thamnophilidae.Rhegmatorhina;

/// <summary>
/// Abstract class for Rhegmatorhina (genus).
/// NCBI TaxId: 288079
/// </summary>
public abstract class Rhegmatorhina : Thamnophilidae, IRhegmatorhina
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhegmatorhina";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 288079;

    /// <inheritdoc />
    public virtual string GenusName => "Rhegmatorhina";

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
