using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Agonidae.Odontopyxis;

/// <summary>
/// Abstract class for Odontopyxis (genus).
/// NCBI TaxId: 320619
/// </summary>
public abstract class Odontopyxis : Agonidae, IOdontopyxis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Odontopyxis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 320619;

    /// <inheritdoc />
    public virtual string GenusName => "Odontopyxis";

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
