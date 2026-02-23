using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Iracundus;

/// <summary>
/// Abstract class for Iracundus (genus).
/// NCBI TaxId: 274696
/// </summary>
public abstract class Iracundus : Scorpaenidae, IIracundus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iracundus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 274696;

    /// <inheritdoc />
    public virtual string GenusName => "Iracundus";

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
