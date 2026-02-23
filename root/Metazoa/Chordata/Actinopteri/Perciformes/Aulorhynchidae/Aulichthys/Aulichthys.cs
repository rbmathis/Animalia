using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Aulorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Aulorhynchidae.Aulichthys;

/// <summary>
/// Abstract class for Aulichthys (genus).
/// NCBI TaxId: 149087
/// </summary>
public abstract class Aulichthys : Aulorhynchidae, IAulichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aulichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 149087;

    /// <inheritdoc />
    public virtual string GenusName => "Aulichthys";

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
