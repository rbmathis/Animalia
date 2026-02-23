using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Platycephalidae.Ambiserrula;

/// <summary>
/// Abstract class for Ambiserrula (genus).
/// NCBI TaxId: 1230792
/// </summary>
public abstract class Ambiserrula : Platycephalidae, IAmbiserrula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ambiserrula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1230792;

    /// <inheritdoc />
    public virtual string GenusName => "Ambiserrula";

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
